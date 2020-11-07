function solve(arg) {
    result = arg.sort((a, b) => a - b).slice(0, 2);
    console.log(result.join(" "));
}