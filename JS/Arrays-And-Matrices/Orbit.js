function starOrbit(input) {

    let x = input[0];
    let y = input[1];
    let sc1 = input[2];
    let sc2 = input[3];

    var result = [];

    for (var i = 0; i < x; i++) {
        var rs = [];
        for (var j = 0; j < y; j++) {
            rs.push(0);
        }
        result.push(rs);

    }
    // for (let row = 0; row < x; row++) {
    //     for (let col = 0; col < y; col++) {
    //         result[row][col] = Math.max(Math.abs(row - sc1), Math.abs(col - sc2)) + 1;
    //     }
    // }

    result[sc1][sc2] = 1;
    findingNeighbors(result, sc1, sc2);

    function findingNeighbors(myArray, i, j) {
        var rowLimit = myArray.length - 1;
        var columnLimit = myArray[0].length - 1;
        let toTheSky = 1;
        for (var x = Math.max(0, i - 1); x <= Math.min(i + 1, rowLimit); x++) {
            for (var y = Math.max(0, j - 1); y <= Math.min(j + 1, columnLimit); y++) {
                if (x !== i || y !== j) {
                    myArray[x][y] = Math.max(Math.abs(x - sc1), Math.abs(y - sc2)) + 1;
                }
            }

        }
    }
    console.log(result.map(row => row.join(' ')).join('\n'));
}

starOrbit([5, 5, 0, 0]);