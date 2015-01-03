

/* This is Flowers Websites Actions JS */

$(function () {
    //alert('test');

    //导航滑动下拉菜单
    var time;
    var target;
    function isContains(parent, e) {
        if (!e) e = window.event;
        var reltg = e.relatedTarget ? e.relatedTarget : e.toElement;
        while (reltg && reltg != parent) reltg = reltg.parentNode;
        return reltg == parent;
    }
    $('.ThisTitle').bind({
        mouseover: function (e) {
            if (!isContains($(this)[0], e)) {
                window.clearTimeout(time);
                $(".ThisList").hide();
                target = $(this).closest(".ThisWrap").children(".ThisList");
                target.show();
            }
        },
        mouseout: function (e) {
            if (!isContains($(this)[0], e)) {
                time = window.setTimeout(function () {
                    target.hide();
                }, 800);
            }
        }
    });

    $('.ThisList').bind({
        mouseover: function (e) {
            if (!isContains($(this)[0], e)) {
                window.clearTimeout(time);
                target = $(this);
            }
        },
        mouseout: function (e) {
            if (!isContains($(this)[0], e)) {
                time = window.setTimeout(function () {
                    target.hide();
                }, 800);
            }
        }
    });

    //显示隐藏微信二维码
    $('.qrcode').click(function () {
        $('.weixinbox').slideDown("slow");
    });
    $('.wxclose').click(function () {
        $('.weixinbox').slideUp("slow");
    });

    //滑动提示花语
    $('.inpros').mouseenter(function () {
        $(this).children().next().fadeIn('slow');
    });
    $('.inpros').mouseleave(function () {
        $(this).children().next().fadeOut('slow');
    });

    $('.hpimg').mouseenter(function () {
        $(this).children().next().fadeIn('slow');
    });
    $('.hpimg').mouseleave(function () {
        $(this).children().next().fadeOut('slow');
    });




    //去掉 fancybox 叠加在body 上面的样式
    $('body').removeClass('fancybox-lock');
    //fancybox
    $('.protimg').fancybox();


    //给指定样式文本框加效果
    $(".input-txt").each(function () {
        $(this).mouseover(function () {
            $(this).focus();
        }).focus(function () {
            $(this).addClass("input-focus")
        }).blur(function () {
            $(this).removeClass("input-focus")
        })
    });

});























































