function solve(input = []) {

    let result = [];
    let rotations = input.pop();

    let total = rotations > input.length ? rotations % input.length : rotations;

    for (let index = 0; index < total; index++) {
        
        input.unshift(input.pop());
    }
    console.log(input.join(' '))
}