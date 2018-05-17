"use strict";

function calcDistance3d([p1x, p1y, p1z, p2x, p2y, p2z]) {
    let deltaX = p2x - p1x;
    let deltaY = p2y - p1y;
    let deltaZ = p2z - p1z;

    let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

    console.log(distance);
}

//d=(x1−x0)2+(y1−y0)2+(z1−z0)2−−−−−−−−−

calcDistance3d([3.5, 0, 1, 0, 2, -1]);