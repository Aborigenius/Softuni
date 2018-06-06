function matchWholeWords(str) {

    let pattern = /\s*[.,|;\n\t-]+\s*/;
    console.log(str.split(/\W+/g).filter(w => w != "").join("|"));

}

matchWholeWords('A Regular Expression needs to have the global flag in order to match all occurrences in the text');
matchWholeWords('_(Underscores) are also word characters');