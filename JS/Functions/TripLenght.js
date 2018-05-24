"use strict";

function tripLenght(input) {
    let [x1, y1, x2, y2, x3, y3] = [Number(input[0]), Number(input[1]), Number(input[2]),
        Number(input[3]), Number(input[4]), Number(input[5])
    ];

    let p1p2 = Math.hypot(x2 - x1, y2 - y1);
    let p2p3 = Math.hypot(x3 - x2, y3 - y2);
    let p1p3 = Math.hypot(x3 - x1, y3 - y1);

    let p1p2p3 = p1p2 + p2p3;
    let p1p3p2 = p1p3 + p2p3;
    let p2p3p1 = p2p3 + p1p2;

    var shorter = Math.min(p1p2p3, p1p3p2, p2p3p1);
    console.log(shorter);

}

tripLenght([0, 0, 2, 0, 4, 0]);
tripLenght([-1, -2, 3.5, 0, 0, 2]);