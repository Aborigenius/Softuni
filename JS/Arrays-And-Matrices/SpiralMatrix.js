function generateSpiralArray(n) {
    var total = n * n;
    var result = [];

    for (var i = 0; i < n; i++) {
        var rs = [];
        for (var j = 0; j < n; j++) {
            rs.push(0);
        }
        result.push(rs);
    }

    var x = 0;
    var y = 0;
    var step = 0;
    for (var i = 0; i < total;) {

        //in case n = 5;
        //Iteration i =0, x =0, y =0, step =0 
        //while(y+step<n) current result with x =1, y =4 - fill first row with 1 - 5
        while (y + step < n)

            while (y + step < n) {
            i++;
            result[x][y] = i;
            y++;

        }
        y--;
        x++;


        //while(x+step<n) 
        //current result with x =4, y =3 - fill last y row 6 to 9

        while (x + step < n) {
            i++;
            result[x][y] = i;
            x++;
        }
        x--;
        y--;


        //while(y>=step) 
        //current result with x =3, y =0 - fill last row 10 - 13

        while (y >= step) {
            i++;
            result[x][y] = i;
            y--;
        }
        y++;
        x--;
        step++;


        //while(x>=step) 
        //x =1, y =1 - adds 14 to 16 

        while (x >= step) {
            i++;
            result[x][y] = i;
            x--;
        }
        x++;
        y++;
        //Iteration i =16, x =1, y =1, step =1 - goes to internal square and repeats the filling
        // and finally Iteration i =24, x =2, y =2, step =2 - and goes to internal internal square
    }
    console.log(result.map(row => row.join(' ')).join('\n'));
}



generateSpiralArray(5);