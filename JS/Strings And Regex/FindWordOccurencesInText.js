function findOccurences(str, word) {
    word = "\\b" + word + "\\b";
    //  console.log(word);
    let regex = new RegExp(word, "gi");
    let resu = str.match(regex);
    console.log(resu.length);
}

findOccurences('There was one. Therefore I bought it. I wouldn’t buy it otherwise.', 'there');