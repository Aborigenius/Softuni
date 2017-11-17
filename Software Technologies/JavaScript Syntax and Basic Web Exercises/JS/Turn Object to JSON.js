keyValue([
    "name -> Angel",
    "surname -> Georgiev",
    "age -> 20",
    "grade -> 6.00",
    "date -> 23/05/1995",
    "town -> Sofia"
]);

function keyValue(input) {
    var tokens = new Array();
    var obj = [];
    for (let p of input) {
        token = p.split(" -> ");
        tokens.push(token);

        for (let t of tokens) {
            let O = [];
            O[t[0]] = t[1];
            obj.push(O);
        }

    }

    console.log(JSON.stringify(obj));
}