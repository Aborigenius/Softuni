function matrix(m, n) {
    var g = Array.from(new Array(N), (val, index) => index + 1);
    console.log(g);
    var result = [];
    for (var i = 0; i < n; i++) {
        result.push(new Array(n).fill(i + 1));
    }
    return result;


}
console.log(matrix(5, 5));