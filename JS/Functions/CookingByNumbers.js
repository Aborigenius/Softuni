function cookNum(arr) {
    // let [num1, op1, op2, op3, op4, op5] = [Number(arr[0]), arr[1], arr[2], arr[3], arr[4], arr[5]];
    let num = arr[0];

    let chop = num => num / 2;
    let dice = num => Math.sqrt(num);
    let spice = num => ++num;
    let bake = num => num * 3;
    let fillet = num => num * 0.8;

    for (var index = 1; index < arr.length; index++) {
        let operation = arr[index];
        console.log(doOp(operation));
    }

    function doOp(operation) {
        if (operation == 'chop') {
            num = num / 2;
        } else if (operation == 'dice') {
            num = Math.sqrt(num);
        } else if (operation == 'spice') {
            num = num + 1;
        } else if (operation == 'bake') {
            num = num * 3;
        } else if (operation == 'fillet') {
            num = num * 0.8;
        }
        return num;
    }


}

cookNum([32, 'chop', 'chop', 'chop', 'chop', 'chop']);