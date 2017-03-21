function changeParagrapgh() {
    document.getElementById("firstpar").innerHTML = "JavaScript Paragraph.";
}

// add two numbers

function calculate(numone, numtwo) {
    var result = numone + numtwo;
    return result;
}



function showdata() { 
    var resulttwo = calculate(10,40);
    document.getElementById("showData").innerHTML = resulttwo;
}

