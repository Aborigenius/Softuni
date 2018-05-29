"use strict";

function printEveryNthElementfromanArray(input) {
    let step = Number(input.pop());
    for (var index = 0; index < input.length; index += step) {
        console.log(input[index]);
    }
}

printEveryNthElementfromanArray(['5', '20', '31', '4', '20', '2']);