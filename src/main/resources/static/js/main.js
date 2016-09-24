$(document).ready(function(){
  $('.speak-button').on('click',function(){
    recognition.start();
  });
  $('.search-text').on('click',function(){
    var message = $('.text-input').val();
    console.log(message);
    convertTextToVideos(message);
    console.log("searching the text now");
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
});
