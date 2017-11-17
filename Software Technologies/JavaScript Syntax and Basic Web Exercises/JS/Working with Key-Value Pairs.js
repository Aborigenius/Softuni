keyValue([
    "key value",
    "key euval",
    "test tset",
    "key"
]);

function keyValue(input) {
    let dict = {};
    for (let i = 0; i < input.length - 1; i++) {
        let tokens = input[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        dict[key] = value;
    }
    let key = input[input.length - 1];
    if (dict[key] == undefined) {
        console.log("None");
    } else
        console.log(dict[key]);

}