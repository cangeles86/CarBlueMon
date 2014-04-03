$(document).ready(function () {
    $('#Menu').mouseenter(function () {
        $("#SubMenu").css('display', 'block');
    });
    $('#Menu').mouseleave(function () {
        $("#SubMenu").css('display', 'none');
    });
    $('.mmRegistrationList').hover(function () {
        $('.mmRegistration').toggleClass('hovered');
    });
    $('.mmAlertList').hover(function () {
        $('.mmAlert').toggleClass('hovered');
    });
});