"use strict";

function multiplTable (n){
    var result = "<table border='1'>";
    result += "<tr><th>x</th>";
    for (var i = 0; i <= n; i++) {
    
        for (var j = 0; j <= n; j++) {
    
            if(i == 0 && j > 0){
              result += `<th>${j}</th>`;
            } 
            else if(j == 0 && i>0){
              result += `<th>${i}</th>`;
            } 
            else if(i>0 && j>0){
            result += `<td>${i*j}</td>`;
            }
        }
        result += "</tr><tr>";
    }
    result = result.slice(0, -4);
    result += "</table>";
console.log(result);
}

multiplTable(5);