var mover = (function () {
    "use strict";
    var module = {
        MoveImage: $(document).ready(function () {
            var isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry/i.test(navigator.userAgent) ? true : false;
            var movementStrength = 25;
            var height = movementStrength / $(window).height();
            var width = movementStrength / $(window).width();
            $("#top-image").mousemove(function (e) {
                if (!isMobile) {
                    var pageX = e.pageX - ($(window).width() / 2);
                    var pageY = e.pageY - ($(window).height() / 2);
                    var newvalueX = width * pageX * -1 - 50;
                    var newvalueY = height * pageY * -1 - 75;
                    $('#top-image').css("background-position", newvalueX + "px     " + newvalueY + "px");
                }
            });
        }),
    }
    return module;
})();