"use strict";

function lastMonth([day, month, year]) {
    var d = new Date(year, month - 1, day);
    d.setDate(1);
    d.setHours(-1);
    d = d.toISOString().split('T')[0];

    var lastDay = d.slice(-2);
    console.log(lastDay);


}

lastMonth([17, 3, 2002]);