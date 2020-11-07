function solve(arg) {
    console.log(arg.filter((x, y) => y % 2 == 1).map(x => x * 2).reverse().join(" "));
}