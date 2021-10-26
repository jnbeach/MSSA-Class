const users = {
    username: "Juan",
    password: "1234"
}

function validatePassword() {
    var password = document.getElementById('password').value;
    var passmessage = document.getElementById('message1');

    if (password === users.password) {
        passmessage.innerHTML = "Correct password";
        passmessage.className = "correct";

    } else if (password == "") {
        passmessage.innerHTML = "";
    }

    else {
        passmessage.innerHTML = "Wrong password";
        passmessage.className = "wrong";
    }
}

function validateUserName() {
    var username = document.getElementById('userName').value;
    var userNameMessage = document.getElementById('message2');

    if (username === users.username) {
        userNameMessage.innerHTML = "Correct username";
        userNameMessage.className = "correct";

    } else if (username == "") {
        userNameMessage.innerHTML = "";
    }

    else {
        userNameMessage.innerHTML = "Wrong username";
        userNameMessage.className = "wrong";
    }
}

