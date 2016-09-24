var splitSentenceToWords = function(word){
  var words_array = word.toLowerCase().split(' ');
  return words_array;
};
var dictionary = {
  'how':'how.MP4',
  'hello my name is Sarah' : 'Hello my name Sarah.MP4',
  'when':'when.MP4'
};

var convertTextToVideos = function(statement){
  var texts = splitSentenceToWords(statement);
  console.log(texts);
  for (var i = 0; i < texts.length; i++) {
    console.log(dictionary[texts[i]]);
  }
};
