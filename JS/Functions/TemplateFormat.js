"use strict";

function quizXml(input) {

    var quotedAndCommaSeparated = input.join(",");
    var something = input.split(",");
    // console.log(quotedAndCommaSeparated);

    for (let i = 0; i < something.length; i++) {
        console.log(something[i]);

    }
    // <?xml version="1.0" encoding="UTF-8"?>
    // <quiz>
    //   <question>
    //     Who was the forty-second president of the U.S.A.?
    //   </question>
    //   <answer>
    //     William Jefferson Clinton
    //   </answer>
    // </quiz>

}

quizXml(["Dry ice is a frozen form of which gas?", "Carbon Dioxide", "What is the brightest star in the night sky?", "Sirius"]);