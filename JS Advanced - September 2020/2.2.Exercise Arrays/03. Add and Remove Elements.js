function solve(input = []) {

    let result = [];
    let currentNumber = 0;

    for (let index = 0; index < input.length; index++) {

        let command = input[index];

        if (command === "add") {

            result.push(++currentNumber);
        } else {

            result.pop(++currentNumber);
        }
    }
    console.log(result.length > 0 ? result.join('\n') : 'Empty')
}