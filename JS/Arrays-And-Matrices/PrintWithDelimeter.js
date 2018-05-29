"use strict";

function printWithDelimeter(input) {

    let delimeter = input.pop();
    console.log(input.join(delimeter));
}

printWithDelimeter(['One', 'Two', 'Three', 'Four', 'Five', '-']);