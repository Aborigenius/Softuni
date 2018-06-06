function aggregateTable(input) {
    let result = [];
    let sum = 0;

    for (var index = 0; index < input.length; index++) {
        let tokens = input[index].split('|');
        result.push(tokens[1].trim());
        sum += Number(tokens[2].trim());
    }
    console.log(result.join(', '));
    console.log(sum);
}

aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275'
]);