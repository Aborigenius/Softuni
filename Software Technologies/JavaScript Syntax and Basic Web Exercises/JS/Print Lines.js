function printLines(input) {
    for (let line of input) {
        if (line == "Stop") {
            break;
        } else {
            console.log(line);
        }
    }
}