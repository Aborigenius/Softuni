function extractUsername(inputArr) {
    for (let mail in inputArr) {
        let [username, rest] = inputArr[mail].split('@');
        inputArr[mail] = username + '.' + rest.split('.').map(a => a[0]).join('');


    }
    console.log(inputArr.join(", "));
}

extractUsername(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']);