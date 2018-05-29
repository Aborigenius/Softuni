"use strict";

function rotateArray(input) {
    let howManyTimes = input.pop();

    while (howManyTimes--) {
        input.splice(0, 0, input.pop());
    }
    console.log(input.join(' '));
}

rotateArray(['Banana', 'Orange', 'Coconut', 'Apples', '15']);