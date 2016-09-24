$(document).ready(function(){
  $('.speak-button').on('click',function(){
    recognition.start();
  });

  $('.video').hide();

  $('form').submit(function(e) {
      e.preventDefault();
      $('.video').show();
      const search = $('[name="search"]').val().toLowerCase();
      console.log(search);
      currentIndex = 0;
      words = search.split(" ");
      Videos.play();
  });
  $('body').on('keypress',function(e){
    var message = $('.text-input').val();
    if (e.keyCode === 13){
      if (message !== '' ){
        // $('form').submit();
        console.log(message);
      }else{
        alert("Say something!");
      }
    }
  });
});
