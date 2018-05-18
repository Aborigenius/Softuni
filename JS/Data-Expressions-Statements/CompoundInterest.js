"use strict";

function calcInterest([initialSum, interestRate, compFreqMonths, timespanYears]) {

    // equatation is result = initialSum * [[1 + (interestRate/4 - how many times per year)] ^ timesPerYear timespanYears]
    let updatesPerYear = 12 / compFreqMonths;
    let result = (initialSum * Math.pow((1 + (interestRate / (updatesPerYear * 100))), (updatesPerYear * timespanYears)));
    //Interest is
    //let interest = (result.toFixed(2) - initialSum).toFixed(2);
    console.log(result.toFixed(2));
    //  console.log(interest);

}

calcInterest([100000, 5, 12, 25]);