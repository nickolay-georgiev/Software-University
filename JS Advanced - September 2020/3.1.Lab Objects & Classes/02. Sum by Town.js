function solve(input = []) {

    let resultObj = input.reduce((acc, value, i, array) => {

        if (i % 2 == 0) {

            if (!acc[`${array[i]}`]) {

                acc[`${array[i]}`] = Number(array[i + 1]);
            }
            else {
                acc[`${array[i]}`] += Number(array[i + 1]);
            }
        }
        return acc;

    }, {})

   console.log(JSON.stringify(resultObj));
}