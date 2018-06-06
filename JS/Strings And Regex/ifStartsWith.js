function ifStartsWith(srt, startString) {

    if (srt.substring(0, startString.length) == startString) {
        console.log(true);
    } else {
        console.log(false);
    }
}

ifStartsWith('How blah blah', 'gow');