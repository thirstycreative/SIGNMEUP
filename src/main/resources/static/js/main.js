$(document).ready(function(){
  console.log('doc is rdy');
  $('.speak-button').on('click',function(){
    console.log("button clicked");
    recognition.start();
  });
});
