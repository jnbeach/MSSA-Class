const inputBox = document.getElementById("userInput");
const messageBox = document.getElementById("message");
const plusButton = document.getElementById("plus")
const minusButton = document.getElementById("minus")
const multButton = document.getElementById("mult")
const divideButton = document.getElementById("divide")
let tempNumber1 = 0;
let tempNumber2 = 0;
let operation = ""
let result = 0;

function numberClick(buttonId) {
    let numberClicked = buttonId;
    console.log(`The ${numberClicked} button was clicked.`);
    inputBox.value = inputBox.value + numberClicked;
    console.log("Number Send Complete")
    messageBox.innerText = "I've got that number baby!"
}

function opClick(buttonId) {
    tempNumber1 = inputBox.value;
    console.log(tempNumber1);
    operation = buttonId;
    inputBox.value = ""
    console.log("Operation Send Complete")
    messageBox.innerText = "Oh yeah. You got another number for me?"

    disableOps();
}

function equalClick() {
    tempNumber2 = inputBox.value
    switch (operation) {
        case "plus":
            result = parseInt(tempNumber1) + parseInt(tempNumber2);
            break;
        case "minus":
            result = parseInt(tempNumber1) - parseInt(tempNumber2);
            break;
        case "mult":
            result = parseInt(tempNumber1) * parseInt(tempNumber2);
            break;
        case "divide":
            result = parseInt(tempNumber1) / parseInt(tempNumber2);
            break;
        default:
            break;
    }
    inputBox.value = ""
    inputBox.placeholder = result;
    operation = ""
    enableOps();
    console.log("Calculation Completed")
    messageBox.innerText = "Calculation Completed. Groooovy baby!"
    showImage();
    // delay(2000).then(hideImage());
    setTimeout(function () { hideImage() }, 2300);
}

function clearCalc() {
    if (inputBox.value == "") {
        operation = ""
    }
    inputBox.value = ""
    inputBox.placeholder = "0";
    console.log("Calculator cleared.");
    messageBox.innerText = "Cleared that number out baby!"
    if ((inputBox.value == "") && (operation == "")) {
        messageBox.innerText = "No operations or numbers stored here baby!"
    }
}

function disableOps() {
    plusButton.disabled = true;
    minusButton.disabled = true;
    multButton.disabled = true;
    divideButton.disabled = true;

    plusButton.classList.replace("enabledOperator", "disabledOperator");
    minusButton.classList.replace("enabledOperator", "disabledOperator");
    multButton.classList.replace("enabledOperator", "disabledOperator");
    divideButton.classList.replace("enabledOperator", "disabledOperator");

    // There's a sexier way to iterate through all elements by class
    // but it's not working for me.
    //
    // let operatorButtons = document.getElementsByClassName("enabledOperator")
    // console.log(operatorButtons);
    // operatorButtons.forEach(element => {
    //     element.disabled = true;
    //     element.class = "disabledOperator";
    // });
}

function enableOps() {
    plusButton.disabled = false;
    minusButton.disabled = false;
    multButton.disabled = false;
    divideButton.disabled = false;

    plusButton.classList.replace("disabledOperator", "enabledOperator");
    minusButton.classList.replace("disabledOperator", "enabledOperator");
    multButton.classList.replace("disabledOperator", "enabledOperator");
    divideButton.classList.replace("disabledOperator", "enabledOperator");
};

function showImage() {
    var img = document.getElementById("yeahBaby");
    img.style.visibility = "visible";
}

function hideImage() {
    var img = document.getElementById("yeahBaby");
    img.style.visibility = "hidden";
}
