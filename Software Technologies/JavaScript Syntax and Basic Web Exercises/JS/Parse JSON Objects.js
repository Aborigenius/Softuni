keyValue([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
]);

function keyValue(input) {
    var dict = [];
    for (let p of input) {
        let obj = JSON.parse(p);
        dict.push(obj);
    }
    for (let student of dict) {
        for (let str of Object.keys(student)) {
            console.log(`${str.replace(/\w\S*/g, function(txt)
                 {return txt.charAt(0).toUpperCase() + txt.substr(1)
                    .toLowerCase(); })}: ${student[str]}`)
        }
    }
}