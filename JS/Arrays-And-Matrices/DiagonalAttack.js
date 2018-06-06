function diagonalCalc(input) {
    let matrix = input.map(row => row.split(" ").map(Number));
    if (diagonalsSum(matrix) != false) {
        var num = diagonalsSum(matrix);

        for (let row = 0; row < matrix.length; row++) {
            for (var column = 0; column < matrix.length; column++) {
                if (row == column || row + column + 1 == matrix.length) {
                    continue;
                } else {
                    matrix[row][column] = num;
                }
            }
        }
    }
    console.log(matrix.map(row => row.join(' ')).join('\n'));

    function diagonalsSum(matrix) {
        let normalDiagonal = 0;
        let backDiagonal = 0;
        for (let row = 0; row < matrix.length; row++) {
            normalDiagonal += matrix[row][row];
            backDiagonal += matrix[row][matrix[row].length - 1 - row];
        }
        // return { normalDiagonal, backDiagonal };
        if (normalDiagonal === backDiagonal) {
            return normalDiagonal;
        } else {
            return false;
        }
    }
}

diagonalCalc([
    '5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1'
]);