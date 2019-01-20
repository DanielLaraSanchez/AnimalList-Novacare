$(document).ready(function (){


let x = 0;
let y = '';

console.log("DanielLara");



let theForm = $('#theForm');
theForm.hide();

let button = $('#buyButton');

button.on('click', function() {
    console.log('buying item');
});

let productInfo = $('#productProps li');
productInfo.on('click', function() {

console.log("you clicked on " + $(this).text())
});

let $loginToggle = $('#loginToggle')
let $popUpForm = $('#popUpForm');


});