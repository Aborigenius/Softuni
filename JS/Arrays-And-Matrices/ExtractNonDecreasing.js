"use strict";

function extractNonDecreasing(input) {
    input = input.map(Number);
    // let biggestNum = input[0];
    // let result = [];
    // for (let i = 0; i < input.length; i++) {
    //     if (input[i] >= biggestNum) {
    //         biggestNum = input[i];
    //         result.push(biggestNum);
    //     }
    // }
    // console.log(result.join("\n"));
    console.log(input.filter(x => x >= 12));


}

extractNonDecreasing([1, 3, 8, 4, 10, 12, 3, 2, 24]);