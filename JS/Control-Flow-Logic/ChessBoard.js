"use strict";

function drawChessboard(size) {
    let result = '<div class="chessboard">\n';
    for (let row = 0; row < size; row++) {
        result += "  <div>\n";
        let color = (row % 2 === 0) ? "black" : "white";
        for (let column = 0; column < size; column++) {

            result += `    <span class="${color}"></span>\n`;
            color = (color === "white") ? 'black' : 'white';
        }

        result += "</div>\n";
    }
    console.log(result += "</div>\n");
}

drawChessboard(8);