"use strict";

function quizXml(input) {

    var quotedAndCommaSeparated = input.join(",");
    var something = quotedAndCommaSeparated.split(",");
    console.log('<?xml version="1.0" encoding="UTF-8"?>');
    console.log('<quiz>');
    for (let i = 0; i < something.length; i += 2) {

        console.log('  <question>');
        console.log('    ' + something[i]);
        console.log('  </question>');
        console.log('  <answer>');
        console.log('    ' + something[i + 1]);
        console.log('  </answer>');

    }
    console.log('</quiz>');

}

quizXml(["Dry ice is a frozen form of which gas?", "Carbon Dioxide", "What is the brightest star in the night sky?", "Sirius"]);