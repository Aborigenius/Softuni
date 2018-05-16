"use strict";

function calcTriangleAreaHeron(a, b, c) {
    let semiPermieter = (a + b + c) / 2;
    let area = Math.sqrt(semiPermieter * (semiPermieter - a) * (semiPermieter - b) * (semiPermieter - c));
    console.log(area);
}

calcTriangleAreaHeron(2, 3.5, 4);