"use strict";

function sortBy2(input) {
    let cmp = function (a, b) {
        if (a > b) return +1;
        if (a < b) return -1;
        return 0;
    };

    // input.sort(function (a, b) {
    //     if (a.length > b.length) {
    //         return +1;
    //     } else if (b.length > a.length) {
    //         return -1;
    //     } else {
    //         return 0;
    //     }
    // });
    input.sort(function (a, b) {
        return cmp(a.length, b.length || a.toLowerCase(), (b.toLowerCase()));
    });

    console.log(input.join("\n"));

}

//sortBy2(['alpha', 'beta', 'gamma']);
sortBy2(['Deny', 'omen', 'test', 'Default']);