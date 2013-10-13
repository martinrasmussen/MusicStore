// Hover over JS effect
$(document).ready(function () {
    $('.cover-art').hover(function() {
                $(this).children("img").fadeTo('fast', 0.2).end().children(".hover").show();
    }, function() {
                $(this).children("img").fadeTo('fast', 1).end().children(".hover").hide();
    });
});


    
