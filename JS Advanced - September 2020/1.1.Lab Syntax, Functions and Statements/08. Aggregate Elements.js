function solve(firstArg) {
    console.log(firstArg.reduce((a, b) => a + b, 0));
    console.log(firstArg.map(x => 1 / x).reduce((a, b) => a + b, 0));
    console.log(firstArg.join(""));
}