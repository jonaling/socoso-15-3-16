$(document).ready(function () {
    $(document).on('mouseenter', '.divbutton', function () {
        $(this).find(":img").show();
        $(this).find(":butt2").show();
    }).on('mouseleave', '.divbutton', function () {
        $(this).find(":img").hide();
        $(this).find(":butt2").hide();

    });
});