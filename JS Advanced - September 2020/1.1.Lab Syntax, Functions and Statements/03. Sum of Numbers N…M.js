function solve(firstArg, secondArg) {
    let sum = 0;

    for (let index = Number(firstArg); index <= Number(secondArg); index++) {
        sum += index;
    }
    console.log(sum);    
}