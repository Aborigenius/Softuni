"use strict";

function equalNeighbors(matrix) {
    let counter = 0;
    for (var row = 0; row < matrix.length; row++) {
        for (var column = 0; column < matrix[row].length; column++) {
            if (matrix[row][column] === matrix[row][column + 1]) {
                counter++;
            }
            if (matrix[row + 1] && matrix[row][column] === matrix[row + 1][column]) {
                counter++;
            }
        }
    }
    console.log(counter);

}
equalNeighbors([
    ['2', '3', '4', '7', '0'],
    ['4', '0', '5', '3', '4'],
    ['2', '3', '5', '4', '2'],
    ['9', '8', '7', '5', '4']
]);