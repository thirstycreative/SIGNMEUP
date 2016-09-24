$(document).ready(function(){
  console.log('doc is rdy');
  $('.speak-button').on('click',function(){
    console.log("button clicked");
    recognition.start();
  });
  $('.search-text').on('click',function(){
    var message = $('.text-input').val();
    console.log(message);
    convertTextToVideos(message);
    console.log("searching the text now");
  });
});
