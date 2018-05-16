"use strict";

function oddEven(num1) {
    if (!Number.isInteger(num1)) {
        console.log("invalid");
    } else if (num1 % 2 !== 0) {
        console.log("odd");
    } else {
        console.log("even");
    }
}

oddEven(5);
oddEven(8);
oddEven(1.5);