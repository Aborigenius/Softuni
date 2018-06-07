function secretCensorship(arr) {
    let namesRegex = /\*[A-Z]{1}[a-zA-Z]*(?=\t| |$)/g; //starting with * one Capital follwed by small ending with space or tab
    let phoneRegex = /\+[0-9\-]{10}(?=\t| |$)/g; //starting with + numbers and dashes with length 10 ending with space or tab
    let idRegex = /\![a-zA-Z0-9]+(?=\t| |$)/g; //starting with ! [w]+ ending with space or tab
    let basesRegex = /\_[a-zA-Z0-9]+(?=\t| |$)/g; //starting with _ a-z and nums (\w+) ending with space or tab

    // let subs = "|".repeat(arr.length);
    // arr = arr.replace(word, subs);
    for (let word of arr) {

        word = word.replace(namesRegex, m => "|".repeat(m.length));
        word = word.replace(phoneRegex, m => "|".repeat(m.length));
        word = word.replace(idRegex, m => "|".repeat(m.length));
        word = word.replace(basesRegex, m => "|".repeat(m.length));

        console.log(word);
    }
}

secretCensorship(['Agent *Ivankov was in the room when it all happened.',
    'I think it was +555-49-796',
    '!2491a23BVB34Q',
    'Base _Aurora21'
]);

//  /\+[0-9\-]{10}(?=\t| |$)/g;