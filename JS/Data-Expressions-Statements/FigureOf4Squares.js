"use strict";

function drawFourSquares(n) {
    var counter = n -2;
    var innerRowsEven = parseInt((n - 3) /2);
    var innerRowsOdd = parseInt((n - 3) /2);

console.log("+" + "-".repeat(counter) + "+" + "-".repeat(counter)  + "+" );
if(n % 2 === 0){
for (let i=0; i<innerRowsEven; i++){
    console.log('|' + " ".repeat(counter) + '|' + " ".repeat(counter) + '|');
}

console.log("+" + "-".repeat(counter) + "+" + "-".repeat(counter)  + "+" );
for (let i=0; i<innerRowsEven; i++){
    console.log('|' + " ".repeat(counter) + '|' + " ".repeat(counter) + '|');
 
}
console.log("+" + "-".repeat(counter) + "+" + "-".repeat(counter)  + "+" );
}
else{
    for (let i=0; i<innerRowsOdd; i++){
        console.log('|' + " ".repeat(counter) + '|' + " ".repeat(counter) + '|');
    }
    
    console.log("+" + "-".repeat(counter) + "+" + "-".repeat(counter)  + "+" );
    for (let i=0; i<innerRowsOdd; i++){
        console.log('|' + " ".repeat(counter) + '|' + " ".repeat(counter) + '|');
     
    }
    console.log("+" + "-".repeat(counter) + "+" + "-".repeat(counter)  + "+" );
    }


}

drawFourSquares(7);