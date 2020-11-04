function solve(arg1) {
    let object = {};
    for (let i = 0; i < arg1.length - 1; i = i + 2) {
        object[arg1[i]] = +arg1[i + 1]
    }
    console.log(object);
}