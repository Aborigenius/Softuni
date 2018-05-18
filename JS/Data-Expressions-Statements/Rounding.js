"use strict";

function rounding([num, roundTo]) {
    if (roundTo > 15) {
        roundTo = 15;
    }
    let rounded = Number(num.toFixed(roundTo));
    //let result = rounded.toString();
    console.log(rounded);
}

rounding([10.51111111112222302300, 25]);