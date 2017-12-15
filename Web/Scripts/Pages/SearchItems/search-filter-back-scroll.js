var blockMainFilters = null;

var filterLoadingIntervalId = window.setInterval(function () {
    blockMainFilters = $(".main-filters");
    if (blockMainFilters.length > 0) {
        window.clearInterval(filterLoadingIntervalId);
    }
}, 20);

var btnBackToFilters = $(".back-to-filters");
var blockMainFilters = $(".main-filters");

$(window).on('scroll', function () {
    if (blockMainFilters === null || blockMainFilters.length === 0) {
        return;
    }

    var scrollTop = $(this).scrollTop();
    var filterHeight = blockMainFilters.outerHeight();
    var isFilterVisible = scrollTop < blockMainFilters.offset().top + filterHeight;

    if (isFilterVisible) {
        btnBackToFilters.fadeOut();
        btnBackToFilters.removeClass("fixed");
    } else {
        btnBackToFilters.fadeIn();
        btnBackToFilters.addClass("fixed");
    }
});

btnBackToFilters.click(function () {
    $("body,html").animate({
        scrollTop: 0
    }, "slow");
})