"use strict";



function moviePrices([title, day]) {

    var loTitle = title.toLowerCase();
    var loDay = day.toLowerCase();

    var obj = {
        'the godfather': { monday: 12, tuesday: 10, wednesday: 15, thursday: 12.50, friday: 15, saturday: 25, sunday: 30 },
        "schindler's list": { monday: 8.50, tuesday: 8.50, wednesday: 8.50, thursday: 8.50, friday: 8.50, saturday: 15, sunday: 15 },
        "casablanca": { monday: 8, tuesday: 8, wednesday: 8, thursday: 8, friday: 8, saturday: 10, sunday: 10 },
        "the wizard of oz": { monday: 10, tuesday: 10, wednesday: 10, thursday: 10, friday: 10, saturday: 15, sunday: 15 },
    };

    if (loTitle in obj && loDay in obj[loTitle]) {

        console.log(obj[loTitle][loDay]);
    } else {
        console.log("error");
    }
}
moviePrices(['the godfather', 'Monday']);
moviePrices(["schindler's list", 'tuesday']);