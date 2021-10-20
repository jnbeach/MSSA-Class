// This was the JS that we coded this morning
var counter = 0;

function buttonClicked() {
    counter = counter + 1;
    console.log("The button has been clicked.");
    console.log("The value of counter is " + counter);

    var myContainer = document.getElementById('mycontainer')

    var dynamicParagraph = "<p> Element " + counter + " added dynamically </p>";
    myContainer.insertAdjacentHTML('beforeend', dynamicParagraph)
}