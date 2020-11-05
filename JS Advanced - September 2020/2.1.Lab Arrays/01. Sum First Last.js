function solve(arg1) {

    let arraySum = 0;

    if (arg1.length > 1) {
        arraySum = Number(arg1.shift()) + Number(arg1.pop());

        console.log(arraySum);
    } else {
        arraySum = Number(arg1.shift());

        console.log(arraySum *2);
    }
}