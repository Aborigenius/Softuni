"use strict";

function PrintBinary(nums) {
    for (let num of nums) {
        console.log(Math.log2(num));
    }
}

PrintBinary([1024, 1, 2, 256]);