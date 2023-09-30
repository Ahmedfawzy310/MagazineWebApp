// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.toggle-icon').click(function () {
        $('.hidden-text').slideDown(800);
        $('.slideup').show();
        $('.toggle-icon').hide();
    });
    $('.slideup').click(function () {
        $('.hidden-text').slideUp(800);
        $('.slideup').hide();
        $('.toggle-icon').show();
    });
    $('select').select2();
   
});




