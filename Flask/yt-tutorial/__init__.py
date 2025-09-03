from flask import Flask, redirect, url_for, render_template, request, session, flash
from datetime import timedelta
from flask_sqlalchemy import SQLAlchemy
from os import path
import os

# --- Flask App Config ---
app = Flask(__name__)
app.config['SECRET_KEY'] = 'your_secret_key'

# --- DB Path ---
BASE_DIR = os.path.abspath(os.path.dirname(__file__))
db_path = os.path.join(BASE_DIR, 'user.db')
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///' + db_path
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
app.permanent_session_lifetime = timedelta(minutes=10)

# --- Database ---
db = SQLAlchemy(app)

class User(db.Model):
    user_id = db.Column(db.Integer, primary_key=True)
    name = db.Column(db.String(150), nullable=False, unique=True)
    email = db.Column(db.String(150), nullable=False)

    def __init__(self, name, email):
        self.name = name
        self.email = email

# --- Routes ---
@app.route('/')
def home():
    return render_template('home.html')

@app.route('/hello/<name>')
def hello(name):
    if name == 'admin':
        return redirect(url_for('admin_hello'))
    if "user" in session:
        name = session["user"]
        flash('Login successful!', "info")
        print(f"🌱🌱🌱 User found in session: {name}")
        return f"<h1>Hello, {name}!</h1>"
    else:
        return redirect(url_for('login'))

@app.route('/user', methods=['GET', 'POST'])
def user():
    email = None
    if "email" in session:
        email = session.get('email')
    if "user" in session:
        name = session["user"]
        if request.method == 'POST':
            email = request.form.get('email')
            session['email'] = email
            try:
                found_user = User.query.filter_by(name=name).first()
                if found_user:
                    found_user.email = email
                    db.session.commit()
                    flash('Email updated successfully!', "info")
                else:
                    flash('User not found in database.', "error")
            except Exception as e:
                db.session.rollback()
                print("⚠️ DB commit error in /user:", e)
                flash('Database error occurred!', 'error')

        return render_template('user.html', name=name, email=email)
    else:
        return redirect(url_for('login'))

@app.route('/greet/<name>/<int:age>')
def greet(name, age):
    print(f"🌱🌱🌱 Received name: {name}, age: {age}, type of age: {type(age)}")
    return f"<h1>Hello, {name}! You are {age} years old.</h1>"

@app.route('/admin')
def admin_hello():
    return "<h1>Welcome to the Admin Page!</h1>"

@app.route('/login', methods=['GET', 'POST'])
def login():
    if "user" in session:
        name = session["user"]
        return redirect(url_for('hello', name=name))
    if request.method == 'POST':
        username = request.form.get('username')
        password = request.form.get('password')
        print(f"🌱🌱🌱 Login attempt with username: {username} and password: {password}")
        session.permanent = True
        if username:
            session['user'] = username
            try:
                found_user = User.query.filter_by(name=username).first()
                if not found_user:
                    user = User(username, "temp@gmail.com")
                    db.session.add(user)
                    db.session.commit()
                else:
                    session['email'] = "temp@gmail.com"
            except Exception as e:
                db.session.rollback()
                print("⚠️ DB commit error in /login:", e)
                flash('Database error occurred during login.', 'error')
                return redirect(url_for('login'))

            flash('Login successful!', "info")
            return redirect(url_for('user'))
    return render_template('auth/login.html')

@app.route('/logout')
def logout():
    name = session.get("user")  # ✅ dùng get để tránh KeyError

    if name:
        try:
            user = User.query.filter_by(name=name).first()
            if user:
                db.session.delete(user)
                db.session.commit()
        except Exception as e:
            db.session.rollback()
            print("⚠️ DB commit error in /logout:", e)
            flash('Database error occurred during logout.', 'error')

        session.pop('user', None)

    session.pop('email', None)
    flash('Logout successful!', "info")
    return redirect(url_for('login'))

# --- Auto-create DB if needed ---
with app.app_context():
    print("📁 Current working dir:", os.getcwd())
    if not path.exists(db_path):
        db.create_all()
        print(f"🌱🌱🌱 Database created at {db_path}")

# --- Run directly ---
if __name__ == '__main__':
    app.run(debug=True)
