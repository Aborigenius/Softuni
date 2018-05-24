"use strict";

function validityPisnaMiOtVas([x1, y1, x2, y2]) {
    [x1, y1, x2, y2] = [x1, y1, x2, y2].map(Number);

    function hypoCheck() {
        let hypo = Math.hypot(x2 - x1, y2 - y1);

        console.log(hypo);

        if (hypo % 1 === 0) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }
}

validityPisnaMiOtVas([3, 0, 0, 4]);