keyValue([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
]);

function keyValue(input) {
    let dict = {};
    for (let p=0; p < input.length; p++) {
        let obj = input[p].split(" -> ");
        let key = obj[0];
        let value = obj[1];
    
        if (key === "age" || key === "grade"){
            value = Number(value);
        }
        dict[key] = value;
    }
let json = JSON.stringify(dict);
console.log(json);
}