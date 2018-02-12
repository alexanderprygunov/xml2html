$(document).ready(function () {
    (function () {
        var node = '.node',
            activeNode = '.node.active',
            nextNodeId = "",
            button = '.button',
            buttonNext = '.button.button__next',
            buttonPrev = '.button.button__back',
            buttonStart = '.button.button__start',
            nodeWrapper = '.node-wrapper';

        $(node).first().addClass('active');

        $(button).on("click", function () {
            nextNodeId = $(this).data('link');
            $(activeNode).removeClass('active');
        });

        $(buttonNext).on("click", function () {
            nextNodeId = $(nodeWrapper).find('#' + nextNodeId).find('.button__next').data('link');
            $(nodeWrapper).find('#' + nextNodeId).addClass('active');
        });

        $(buttonPrev).on("click", function () {
            nextNodeId = $(nodeWrapper).find('#' + nextNodeId).find('.button__back').data('link');
            $(nodeWrapper).find('#' + nextNodeId).addClass('active');
        });

        $(buttonStart).on("click", function () {
            $(node).first().addClass('active');
        });
    })();
});