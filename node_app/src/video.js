var chokidar = require('chokidar');

// Initialise watching subdirectory and ignore files prefixed with full stop
var watcher = chokidar.watch('./videos', {
    ignored: /[\/\\]\./,
    persistent: true
});

// Add event listeners
watcher.on('add', function(path) {
    console.log("Added:", path);
});
