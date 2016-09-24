let currentIndex = 0;
let words = new Array();

function Videos() {
}
Videos.getPath = function(word) {
    return '/videos/' + word + '.MP4';
}

Videos.play = function() {
    videoPlayer = document.getElementById("videoPlayer")
    // remove the event listener, if there is one
    videoPlayer.removeEventListener('ended',Videos.play,false);

    // update the source with the currentVideo from the videos array
    videoPlayer.src = Videos.getPath(words[currentIndex]);
    // play the video
    videoPlayer.load();
    videoPlayer.play();

    // increment the currentIndex
    if (currentIndex < words.length -1) {
        currentIndex = currentIndex + 1;
        // add an event listener so when the video ends it will call the Videos.play function again
        videoPlayer.addEventListener('ended', Videos.play,false);
    }
}
//hello my name is Sarah
//how are you
//do you need a doctor
//where do you want to go

var dic = ["Alex",
"g",
"r",
"Elise",
"go",
"restaurant",
"h",
"s",
"Roslyn",
"help",
"sick",
"Sarah",
"hospital",
"t",
"Tripti",
"how",
"time",
"a",
"i",
"u",
"ambulance",
"j",
"v",
"b",
"k",
"w",
"big",
"l",
"want",
"c",
"little",
"what",
"call",
"m",
"when",
"my",
"where",
"carpet",
"n",
"which",
"cat",
"name",
"who",
"come",
"naughty",
"why",
"d",
"need",
"x",
"do",
"o",
"y",
"doctor",
"on",
"you",
"dog",
"p",
"your",
"e",
"police",
"z",
"f",
"q"];
