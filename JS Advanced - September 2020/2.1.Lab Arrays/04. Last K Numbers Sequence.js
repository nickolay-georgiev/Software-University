function solve(arg1, arg2) {

    let result = [1];    
    while (result.length < arg1) {

        let sum = 0;
        let test = result.length - 1 < arg2 ? 0 : result.length  - arg2;

        for (let j = result.length - 1; j >= test; j--) {

            sum += result[j];
        }

        result.push(sum);
    }
    result.forEach(x => console.log(x));
}