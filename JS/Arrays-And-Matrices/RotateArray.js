"use strict";

function rotateArray(input) {
    let howManyTimes = Number(input.pop());
    howManyTimes %= input.length;

    for (var index = 0; index < howManyTimes; index++) {
        let lastElement = input.pop();
        input.unshift(lastElement);
    }
    console.log(input.join(' '));
}

rotateArray(['Banana', 'Orange', 'Coconut', 'Apples', '15']);