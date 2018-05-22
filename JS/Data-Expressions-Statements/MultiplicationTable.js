"use strict";

function multiplTable(n) {

    let result = "<table border='1'><tr><td>x</td>";
    for (let row = 1; row <= n; row++) {
        result += `<td>${row}</td>`;

    }
    result += "</tr>";
    result += "</table>";
    console.log(result);
}

multiplTable(5);