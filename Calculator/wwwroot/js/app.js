﻿"use strict";
//ajax test

var A = '';
var B = ''; 
var opt = '';
var answer;

var button = document.getElementById('send');
var clear = document.getElementById('clear');

//button.addEventListener('click', Payload);
clear.addEventListener('click', Clear);

function Payload() {
    console.log('launching payload');
    
    $.ajax({
        type: 'POST',
        url: '/Home/Calc',
        data: { numA: A },
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

function Answer() {
    $.get("/Home/Return", function (payload) {
        console.log(`answer payload returned: ${payload}`);
        render(payload);
    });
}

function render(input) {
    $('#Print').val('');
    $('#Print').text(input);
}

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

function AddToB(num) {
    if (B === '') {
        B = num;
        render(A);
    } else {
        let Bcopy = B;
        B = Bcopy + num;
        render(B);
    }
}

function ButtonEvent() {
    
    $(".bt").click(function () {
        
        var input = $(this).attr('value');

        if (input == '=') {
            Payload();
        }

        if (input !== '=') {
            AddToA(input);
        }
        //if (input === '/' || input === '*' || input === '-' || input === '+' && input !== '='){
        //    opt = input;
        //}
        //if (opt === ''){
        //   console.log(input);
        //   AddToA(input);
        //}else {
        //    AddToB(input); 
        //}    

    });
}
    function Clear() {
        $('#Print').val('');
        A = '';
        render('0');
    }

$(document).ready(ButtonEvent);