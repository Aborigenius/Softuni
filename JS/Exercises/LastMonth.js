"use strict";

function lastDayPrevMonth([day, month, year]){
var d = new Date(year, month, day);
console.log(day);
console.log(month);
console.log(d);
}

lastDayPrevMonth([17, 3, 2002]);