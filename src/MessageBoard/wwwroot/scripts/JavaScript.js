$(document).ready(function () {
    
    $(".hidden1").fadeIn(1500);
    $(".hidden1").fadeOut(2500, function () {
        $('.hidden2').fadeIn(1500);
        $('.hidden2').fadeOut(2500, function () {
            $('.hidden3').fadeIn(1500);
            $('.hidden3').fadeOut(2500, function () {
                $('.hidden4').fadeIn(1500);
               
            });
            
        });
       
    });
    
});