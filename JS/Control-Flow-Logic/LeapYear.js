function LeapYear(input) {
    if (input % 400 === 0 || (input % 4 === 0 && input % 100 !== 0)) {
        console.log("yes");
    } else {
        console.log("no");
    }
}

LeapYear(1999);

LeapYear(1900);