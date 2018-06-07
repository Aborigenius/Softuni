"use strict";

function parseToObject(arr) {
    let obj = {};

    // let keys = arr.shift().split(/\s*\|\s*/).filter(a => a !== "");
    arr.shift();

    for (var index = 0; index < arr.length; index++) {

        let values = arr[index].split(/\s*\|\s*/).filter(a => a !== "");
        arr[index] = {
            Town: values[0],
            Latitude: +values[1],
            Longitude: +values[2]
        };

    }
    console.log(JSON.stringify(arr));
}
parseToObject(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |'
]);