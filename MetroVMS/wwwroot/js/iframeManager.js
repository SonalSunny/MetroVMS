var wh; var ww; var resizeTimer = null;
$(document).ready(function () {
    wh = $(window).height();
    ww = $(window).width();
    $(window).bind("resize", function () {
        wh = $(window).height();
        ww = $(window).width();
        if (resizeTimer) clearTimeout(resizeTimer); resizeTimer = setTimeout(sh, 500);
    });
    sh();

    $(".ChangePage").on('click', function () {
        var cpp = document.getElementById("ContFrame");
        cpp.contentWindow.document.body.innerHTML = '<div class="page_loader_parent"> <span class="page_loader"></span> </div>';
        cpp.src = $(this).attr("src");
    });
});
function sh() {
    $("#ContFrame").height(wh - 80);
    //  if ($(".pop").is(":visible")) {
    //     setPopup(ww, wh);
    //  }
}

function loadContentIframe(src) {
    var cpp = document.getElementById("ContFrame");
    cpp.contentWindow.document.body.innerHTML = '<div class="page_loader_parent"> <span class="page_loader"></span> </div>';
    cpp.src = src;
    return false;
}
