"use strict";

function calcDistance([v1, v2, timeInSec]) {
    let timeInH = (timeInSec / 60) / 60;
    let s1 = v1 * timeInH;
    let s2 = v2 * timeInH;

    let result = Math.abs(s1 - s2) * 1000;
    console.log(result);
}

calcDistance([0, 60, 3600]);
calcDistance([11, 10, 120]);
calcDistance([5, -5, 40]);