$(document).ready(function () {

    $("#ddlNavBar").click(function () {
        $("#submenu1").attr("style", "visibility:visible");
        $("#submenu2").attr("style", "display:none");
    });

    $("#liItem1").hover(function () {
        $("#submenu1").attr("style", "visibility:visible");
        $("#submenu2").attr("style", "display:none");
    });
    $("#liItem2").hover(function () {
        $("#submenu1").attr("style", "display:none");
        $("#submenu2").attr("style", "visibility:visible");

    });
});