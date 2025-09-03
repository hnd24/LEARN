from flask import Flask, redirect, url_for, render_template, request, session
from datetime import timedelta

app = Flask(__name__)
app.config['SECRET_KEY'] = 'your_secret_key'
app.permanent_session_lifetime = timedelta(seconds=3)

@app.route('/')
def hello():
    return render_template('home.html', )

@app.route('/user/<name>')
def user(name):
    if name == 'admin':
        return redirect(url_for('admin_hello'))
    return f"<h1>Hello, {name}!</h1>"
@app.route('/hello')
def hello_user():
    if "user" in session:
        name = session["user"]
        print(f"🌱🌱🌱 User found in session: {name}")
        return f"<h1>Hello, {name}!</h1>"
    else: 
        return redirect(url_for('login'))
    

@app.route('/greet/<name>/<int:age>')
def greet(name, age):
    print(f"🌱🌱🌱 Received name: {name}, age: {age}, type of age: {type(age)}")
    return f"<h1>Hello, {name}! You are {age}  years old.</h1>"

@app.route('/admin')
def admin_hello():
    return "<h1>Welcome to the Admin Page!</h1>"

@app.route('/login', methods=['GET', 'POST'])
def login():
    if "user" in session:
        return redirect(url_for('hello_user'))
    if request.method == 'POST':
        username = request.form.get('username')
        password = request.form.get('password')
        # Here you would typically validate the username and password
        print(f"🌱🌱🌱 Login attempt with username: {username} and password: {password}")
        session.permanent = True
        if username:
            session['user'] = username  # Sửa lại key thành 'user' để đồng bộ với hàm user()
            return redirect(url_for('hello_user', name=username))
    return render_template('auth/login.html')

@app.route('/logout')
def logout():
    session.pop('user', None)
    return redirect(url_for('hello_user'))

if __name__ == '__main__':
    app.run(debug=True)