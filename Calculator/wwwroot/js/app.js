"use strict";

var A = '';

//Vanilla JS event listener setup and execution for the clear button.
var clear = document.getElementById('clear');
clear.addEventListener('click', Clear);

//Using JQuery to send a Post ajax call to the HomeController to calculate the users input. 
function Payload() {
    console.log(`launching payload: ${A}`);
    
    $.ajax({
        type: 'POST',
        url: '/Home/Calc',
        data: { input: A },
        dataType: 'text',
        success: OnSuccess,
        error: OnError
    }).then(Answer);
    function OnSuccess() {
        console.log('ajax payload succeeded');
    }
    function OnError() {
        console.log(error);
    }
}
//Ajax Get function to return the answer from the back controller.
function Answer() {
    $.get("/Home/Return", function (payload) {
        console.log(`answer payload returned: ${payload}`);
        render(payload);
    });
}

//Render function for the calculator screen
function render(input) {
    $('#Print').val('');
    $('#Print').text(input);
}

//This function creates the string equasion that will be sent to the controller.
function AddToA(num) {
    if (A === '') {
        A = num;
        render(A);
    } else {
        let Acopy = A;
        A = Acopy + num;
        render(A);
    }
}

//This function is a JQuery event handler that grabs the buttons value and passes it to the equasion string builder.
function ButtonEvent() {
    
    $(".bt").click(function () {
        
        var input = $(this).attr('value');

        if (input === '=') {
            Payload();
        }

        if (input !== '=') {
            AddToA(input);
        }
    });
}

//Clear calculator screen and equasion string.
function Clear() {
  $('#Print').val('');
  A = '';
  render('0');
}

//Activate button event handler when page loads. 
$(document).ready(ButtonEvent);