function solve(arg) {

    let result = [];
    for (let i = 0; i < arg.length; i++) {

        if (arg[i] >= 0) {
            result.push(arg[i]);
        }
        else if (arg[i] < 0) {
            result.unshift(arg[i]);
        }
    }
    result.forEach(x => console.log(x));
}