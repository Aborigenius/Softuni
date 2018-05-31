"use strict";

function biggestInMatrix(matrix) {
    let max = Number.NEGATIVE_INFINITY;
    for (let row = 0; row < matrix.length; row++) {
        for (let column = 0; column < matrix[row].length; column++) {
            if (matrix[row][column] > max) {
                max = matrix[row][column];
            }
        }
    }
    console.log(max);
}

biggestInMatrix([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]
]);