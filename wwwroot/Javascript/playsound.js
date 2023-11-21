window.playSound = function (soundPath, volume) {
    var audio = new Audio(soundPath);
    audio.volume = volume;
    audio.play();
}