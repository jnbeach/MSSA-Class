// Calculate button function
var counter = 0;

function buttonClicked() {
    counter = counter + 1;
    console.log("The button has been clicked.");
    console.log("The value of counter is " + counter);

    var value1 = document.getElementById('number1').value;
    value1 = parseInt(value1);
    var value2 = document.getElementById('number2').value;
    value2 = parseInt(value2);

    var sum = value1 + value2
    document.getElementById('result').value = sum;
}