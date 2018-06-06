function ifStartsWith(srt, startString) {
    //console.log(srt.slice(-startString.length)); 
    if ((srt.slice(-startString.length)) == startString) {
        console.log(true);
    } else {
        console.log(false);
    }
}

ifStartsWith('How blah blaR', 'laR');