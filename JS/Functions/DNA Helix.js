"use strict";

function dnaHelix(input) {
    let helix = 'ATCGTTAGGG';
    input = Number(input);

    if (input <= 5) {
        print5(input);
    }

    function print5(input) {
        for (var index = 0; index < input; index++) {
            if (index % 4 == 0) {
                console.log(`**${helix[0]}${helix[1]}**`);
            }
            if (index % 4 == 1) {
                console.log(`*${helix[2]}--${helix[3]}*`);
            }
            if (index % 4 == 2) {
                console.log(`${helix[4]}----${helix[5]}`);
            }
            if (index % 4 == 3) {
                console.log(`*${helix[6]}--${helix[7]}*`);
            }
        }
        console.log(`**${helix[8]}${helix[9]}**`);
    }
}

dnaHelix(4);