function solve(input = []) {

    let step = Number(input.pop());
    let result = [];

    for (let index = 0; index < input.length; index += step) {

        result.push(input[index]);
    }
    console.log(result.join('\n'));
}
