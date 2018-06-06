function captureNumbers(input) {

    let regex = /\d+/g;
    let text = input.join(' ');
    let nums = text.match(regex);
    console.log(nums.join(' '));
}

captureNumbers(['123a456',
    '789b987',
    '654c321',
    '0'
]);