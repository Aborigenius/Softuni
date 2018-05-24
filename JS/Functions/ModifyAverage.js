"use strict";

function averageValue(input) {
    var arr = (input).toString(10).split('');

    calcSum(arr);

    let result = arr.join("");
    console.log(result);

    function calcSum(arr) {

        while (true) {
            let sum = 0;
            for (var index = 0; index < arr.length; index++) {
                sum += Number(arr[index]);
            }
            sum = sum / arr.length;
            if (sum <= 5) {
                arr.push(9);
            } else {
                return arr;
            }
        }

    }
}

averageValue(5835);