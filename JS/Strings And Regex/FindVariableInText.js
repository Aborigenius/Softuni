function findVaraibales(str) {

    let m;
    const regex = /\b(?:_)([a-zA-Z0-9]+)\b/gm;
    let result = [];
    let match = regex.exec(str);
    // while ((m = regex.exec(str)) !== null) {
    //     // This is necessary to avoid infinite loops with zero-width matches
    //     if (m.index === regex.lastIndex) {
    //         regex.lastIndex++;
    //     }

    //     // The result can be accessed through the `m`-variable.
    //     m.forEach((match, groupIndex) => {
    //         console.log(`Found match, group ${groupIndex}: ${match}`);
    //         result.push(match);
    //     });


    // }
    while (match) {
        result.push(match[1]);
        match = regex.exec(str);
    }
    console.log(result.join(','));
}

findVaraibales('The _id and _age variables are both integers.');