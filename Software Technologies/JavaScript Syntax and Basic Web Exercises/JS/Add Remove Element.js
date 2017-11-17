addRemove([
    "add 3",
    "add 5",
    "remove 2",
    "remove 0",
    "add 7"
]);

function addRemove(input) {
    let arr = [];
    for (let todo of input) {
        let tokens = todo.split(' ');
        let action = tokens[0];
        let num = Number(tokens[1]);
        if (action == "add") {
            arr.push(num)
        }
        if (action == "remove") {
            arr.splice(num, 1);
        }
    }

    for (let item of arr) {
        console.log(item);
    }
}