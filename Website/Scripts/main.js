// Hover over the images effect made by Anthony
$(document).ready(function () {
    $('.cover-art').hover(function() { // on mouse hover do the following:
                $(this).children("img").fadeTo('fast', 0.2).end().children(".hover").show(); // Makes the invisible div visible and fades the image
    }, function() {
                $(this).children("img").fadeTo('fast', 1).end().children(".hover").hide(); // Revereses the effect
    });
});


    
