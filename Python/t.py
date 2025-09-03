from flask import Flask, redirect, url_for

app = Flask(__name__)

@app.route('/')
def hello():
    return "<h1>Hello, World!</h1>"

@app.route('/user/<name>')
def user(name):
    if name == 'admin':
        return redirect(url_for('admin_hello'))
    return f"<h1>Hello, {name}!</h1>"

@app.route('/greet/<name>/<int:age>')
def greet(name, age):
    print(f"🌱🌱🌱 Received name: {name}, age: {age}, type of age: {type(age)}")
    return f"<h1>Hello, {name}! You are {age}  years old.</h1>"

@app.route('/admin')
def admin_hello():
    return "<h1>Welcome to the Admin Page!</h1>"

if __name__ == '__main__':
    app.run(debug=True)