"use strict";

function solve(a, b, c) {
    var result = (-1 * b + Math.sqrt(Math.pow(b, 2) - (4 * a * c))) / (2 * a);
    var result2 = (-1 * b - Math.sqrt(Math.pow(b, 2) - (4 * a * c))) / (2 * a);
    var d = Math.pow(b, 2) - (4 * a * c);
    var r1 = parseFloat((result).toFixed(5));
    var r2 = parseFloat((result2).toFixed(5));
    if (d > 0) {
        console.log(r2);
        console.log(r1);
    } else if (d == 0) {
        console.log(r1);
    } else {
        console.log('No');
    }
}

solve(1, -12, 36);
//solve(6, 11, -35);
//solve(5, 2, 1);