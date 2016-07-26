$(document).ready(function () {

    //var moz = $.browser.mozilla();
    //var userBrowser = $.browser.browser();

    //if (moz == true) {
    //    $("#span-chevron").addClass("glyphicon glyphicon-chevron-right").attr("style", "padding-left: 38px;");
    //} else {
    //    $("#span-chevron").addClass("glyphicon glyphicon-chevron-right pull-right");
    //}

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