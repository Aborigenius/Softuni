function magicMatrices(matrix) {


    let sumCol = matrix.reduce(function(a, b) {
        return a.map(function(v, i) {
            return v + b[i];
        });
    });

    let sumRow = matrix.map(function(y) {
        return y.reduce(function(a, b) {
            return a + b;
        });
    });

    if (JSON.stringify(sumCol) === JSON.stringify(sumRow)) {
        console.log('true');
    } else {
        console.log('false');
    }

}

magicMatrices([

    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]

]);