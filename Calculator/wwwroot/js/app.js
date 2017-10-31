
//ajax test

var A ="5";
var B = "6"; 
var opt = "+";

var obj = {};
obj.numA = "5";
obj.numB = "6";
obj.op = "+";

var button = document.getElementById('send');

button.addEventListener('click', Payload)

function Payload() {
    console.log('launching payload');
    $.ajax({
        type: 'POST',
        url: '/Home/Calc',
        data: { numA: A, numB: B, op: opt },
        dataType: 'text',
        success: OnSuccess,
        error: OnError
    });
    function OnSuccess() {
        console.log('ajax payload succeeded');
    }
    function OnError() {
        console.log(error);
    }
}


