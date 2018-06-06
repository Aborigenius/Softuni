//str.substr(5); // substr(start, length), can use - nums(-1 cuts last char)
//let sub = str.substring(5, 9); // startIndex, endIndex
function indexOfSub(input) {

    let a = input;
    console.log(a.substr(-1));
    console.log(a.substr(-3, 1));

    console.log(a.substring(3)); //by index from to the end if without second param
    console.log(a.substring(0, 2));
}

indexOfSub('abcdef');