"use strict";

function addRemove(input) {
    let initialNum = 1;
    let result = [];
    for (var index = 0; index <= input.length; index++) {
        if (input[index] === 'add') {
            result.push(initialNum);
        }
        if (input[index] === 'remove') {
            result.pop();

        }
        initialNum++;
    }
    if (result.length == 0) {
        console.log("Empty");
    } else {
        result.forEach(element => console.log(element));
    }

}

addRemove(['add', 'add', 'remove', 'add', 'add']);
addRemove(['remove', 'remove']);