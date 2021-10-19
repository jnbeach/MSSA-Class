// Image analyzer function

function analyzeText() {
    var textInput = document.getElementById('TextToAnalyze').value;
    console.log(textInput);
    var textResult = textInput;
    document.getElementById('textResult').value = textResult + " Analyzed.";

}

function analyzeImage() {
    var textInput = document.getElementById('ImageToAnalyze').value;
    console.log(textInput);
    var imgResult = textInput;
    document.getElementById('imageResult').value = imgResult + " Analyzed.";
}