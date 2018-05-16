"use strict";

function generateNumbers(num) {
    let result = "<ul>\n";

    for (let i = 1; i <= num; i++) {
        let color = (i % 2 === 1) ? "green" : "blue";
        result += `  <li><span style='color:${color}'>${i}</span></li>`;
    }
    console.log(result += "</ul>");
}

generateNumbers(10);