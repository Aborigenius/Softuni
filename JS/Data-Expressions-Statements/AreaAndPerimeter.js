"use strict";

function calcAreaPerim(sideA, sideB) {
    let area = sideA * sideB;
    let perimeter = sideA + sideA + sideB + sideB;
    console.log(area);
    console.log(perimeter);
}

calcAreaPerim(2.5, 3.14);
calcAreaPerim(2, 2);
calcAreaPerim(1, 3);