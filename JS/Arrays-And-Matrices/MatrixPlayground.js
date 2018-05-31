function spiralArray(rows, cols) {
    function matrix(rows, cols, defaultValue) {

        var arr = [];

        // Creates all lines:
        for (var i = 0; i < rows; i++) {

            // Creates an empty line
            arr.push([]);

            // Adds cols to the empty line:
            arr[i].push(new Array(cols));

            for (var j = 0; j < cols; j++) {
                // Initializes:
                arr[i][j] = defaultValue;
                defaultValue++;
            }
        }

        return arr;
    }
    x = matrix(rows, cols, 1);

    console.log(x);
}
spiralArray(5, 5);