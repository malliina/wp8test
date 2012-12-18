// without jQuery
window.onload = function () {
    document.getElementById('dynamicParagraph').innerHTML = "running javascript file";
}
function notifyCodeBehind() {
    window.external.notify("ChangeParagraph");
}
function setParagraph() {
    document.getElementById('dynamicParagraph').innerHTML = "user-triggered paragraph";
}
// with jQuery
//$(function () { //shorthand for document.ready
//    "use strict";
//    document.getElementById('dynamicParagraph').innerHTML = "running javascript file";
//})