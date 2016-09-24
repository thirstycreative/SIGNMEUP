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
      words = search.split(" ").filter(key => dic.indexOf(key) >= 0);
      console.log(words);
      Videos.play();
  });
});
