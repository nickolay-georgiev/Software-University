function solve(input) {
    let data = input[0].split(/\W+/gm).filter(x => x != '')

    let result = {};

    for (let index = 0; index < data.length; index++) {

        let currentWord = data[index];

        if (!result[currentWord]) {

            result[currentWord] = 1;
        }
        else {
            result[currentWord]++;
        }
    }
    console.log(JSON.stringify(result));
}