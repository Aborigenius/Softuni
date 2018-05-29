"use strict";




// function IsNumeric(val) {
//     return Number(parseFloat(val)) === val;
// }

function radioCrystal(input) {
    // Crystal is a base class
    class Crystal {

        constructor(name, density) {
            this.name = name;
            this.density = density;
        }
        density() {
            return this.density();
        }

        toString() {
            return `${this.name} | ${this.density}`;
        }

        print() {
            console.log(this.toString());
        }

        cut() {
            return this.density = this.density / 4;
        }

        r() {
            return this.density = Math.floor(this.density);
        }
        lap() {
            return this.density = this.density * 0.8;
        }
        grind() {
            return this.density = this.density - 20;
        }
        etch() {
            return this.density = this.density - 2;
        }
        xray() {
            return this.density = this.density + 1; //could be done once!
        }

    }
    input = input.map(Number);
    let requiredThickness = input[0];
    for (var index = 1; index < input.length; index++) {

        let cutsCounter = 0;
        let grindCounter = 0;
        let lapCounter = 0;
        let etchCounter = 0;
        var pesho = new Crystal('pesho', input[index]);
        console.log(`Processing chunk ${pesho.density} microns`);

        while (pesho.density >= (requiredThickness * 4)) {
            pesho.cut();
            cutsCounter++;
        }
        if (cutsCounter > 0) {
            console.log(`Cut x${cutsCounter}`);
            pesho.r();
            console.log("Transporting and washing");
        }
        while (pesho.density >= (requiredThickness * 1.2)) {
            pesho.lap();
            lapCounter++;

        }
        if (lapCounter > 0) {
            console.log(`Lap x${lapCounter}`);
            pesho.r();
            console.log("Transporting and washing");
        }
        while (pesho.density >= (requiredThickness + 20)) {
            pesho.grind();
            grindCounter++;
        }
        if (grindCounter > 0) {
            console.log(`Grind x${grindCounter}`);
            pesho.r();
            console.log("Transporting and washing");
        }
        while (pesho.density >= requiredThickness + 1) {
            pesho.etch();
            etchCounter++;
        }
        if (etchCounter > 0) {
            console.log(`Etch x${etchCounter}`);
            pesho.r();
            console.log("Transporting and washing");
        }
        if (pesho.density === (requiredThickness - 1)) {
            pesho.xray();
            console.log("X-ray x1");
        }
        console.log(`Finished crystal ${pesho.density} microns`);
    }

}

radioCrystal([1000, 4000, 8100]);