"use strict";

function solve(arr) {
    aggregate(arr, 0, (a, b) => a + b);
    aggregate(arr, 0, (a, b) => a + 1 / b);
    aggregate(arr, "", (a, b) => a + b);

    function aggregate(array, initialValue, func) {
        for (var index = 0; index < array.length; index++) {
            initialValue = func(initialValue, array[index]);
        }
        console.log(initialValue);
    }
}