"use strict";

function moviePricesPlayground([title, day]) {

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

moviePricesPlayground(["Schindler's List", 'Thursday']);
moviePricesPlayground(["schindler's list", 'tuesday']);

/*Movie ticket prices in a big retro-cinema depend on the movie title and on the day of week as shown below: 
Movie Title	Monday	Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
The Godfather	12	10	15	12.50	15	25	30
Schindler's List	8.50	8.50	8.50	8.50	8.50	15	15
Casablanca	8	8	8	8	8	10	10
The Wizard of Oz	10	10	10	10	10	15	15
Write a JS function that calculate the ticket price by movie title and day of week.
The input comes as array of 2 strings. The first string holds the movie title. The second string holds the day of week.
The output should hold the ticket price or “error” if the title or day of week is invalid.
*/