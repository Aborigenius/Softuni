function productOfThreeNumbers(nums) {
    let numOne = Number(nums[0]);
    let numTwo = Number(nums[1]);
    let numThree = Number(nums[2]);
    let countNegative = 0;
    if (numOne == 0 || numTwo == 0 || numThree == 0) {
        console.log("Positive");
    }
    if (numOne < 0) {
        countNegative++;
    }
    if (numTwo < 0) {
        countNegative++;
    }

    if (numThree < 0) {
        countNegative++;
    }
    if (countNegative % 2 == 0) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }

}