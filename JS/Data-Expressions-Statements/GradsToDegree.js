"use strict";

function gradsToDegree(input) {

    let grads = Number(input);
    grads = grads % 400;
    if (grads < 0) {
        grads += 400;
    }
    //or grads = grads < 0 ? 400 + grads : grads;
    let degrees = grads * 0.9;

    console.log(degrees);
}

gradsToDegree(400);
gradsToDegree(-50);
gradsToDegree(850);

//1 Grads = 0.9 Degrees	10 Grads = 9 Degrees	2500 Grads = 2250 Degrees

// 0°≤x<360°,