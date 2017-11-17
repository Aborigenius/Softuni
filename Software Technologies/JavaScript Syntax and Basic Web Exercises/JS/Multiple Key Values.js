keyValue([
    "key value",
    "key euval",
    "test tset",
    "key"
]);

function keyValue(input) {
    var dict = {};
    for (let i = 0; i < input.length - 1; i++) {
        let tokens = input[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        if (!(key in dict)) {
            dict[key] = new Array();
            dict[key].push(value);
        } else {
            dict[key].push(value);
        }
    }
    let key = input[input.length - 1];
    if (dict[key] == undefined) {
        console.log("None");
    } else {
        for (let item of dict[key])
            console.log(item);
    }
}