"use strict";

function calcImperialFeets(inch) {
    let feet = Math.floor(inch / 12);
    let inches = inch %= 12;
    console.log(feet + "'" + "-" + inches + '"');

}


calcImperialFeets(55);
calcImperialFeets(11);