$(function () {
    $("#dialog").dialog({
        autoOpen: false,
        modal: true,
        width: 400,
        buttons: [
            {
                text: "Ok",
                click: function () {
                    $(this).dialog("close");
                    callBack(true);
                }
            },
            {
                text: "Cancel",
                click: function () {
                    $(this).dialog("close");
                    callBack(false);
                }
            }
        ]
    });
});