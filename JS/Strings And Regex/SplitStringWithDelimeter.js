function splitByDelimeter(str, delim) {
    let reg = new RegExp(delim);

    str = str.split(delim);
    console.log(str.join("\n"));
}

splitByDelimeter('One-Two-Three-Four-Five', '-');