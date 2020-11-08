function solve(arg) {

    let result = [];
    let counter = 0;

    let firstSum = 0;
    for (var i = 0; i < arg.length; i++) {

        firstSum += arg[i][counter++];
    }

    result.push(firstSum);
    counter = 0;

    let secondSum = 0;
    for (var i = arg.length - 1; i >= 0; i--) {

        secondSum += arg[i][counter++];
    }

    result.push(secondSum);
    console.log(result.join(" "));    
}