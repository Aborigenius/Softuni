"use strict";

function printSpiral(input) {
    let numCols = input[0];
    let numRows = input[1];

    var innerArrSrc = [];
    var outerArr = [];

    for (var i = 0; i < numCols; i++) {
        innerArrSrc.push(i + 1);
    }

    for (var j = 0; j < numRows; j++) {
        outerArr.push(innerArrSrc.concat()); // Could also use innerArrSrc.slice();
    }
    console.log(outerArr);
}

printSpiral([5, 5]);