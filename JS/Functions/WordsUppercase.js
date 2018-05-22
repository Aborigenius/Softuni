"use strict";

function wordsUppercase(str){

console.log(str.split(/\W+/).filter(w => w !== '').map(w => w.toUpperCase()).join(', '));
}

wordsUppercase('Hi, how are you?');
