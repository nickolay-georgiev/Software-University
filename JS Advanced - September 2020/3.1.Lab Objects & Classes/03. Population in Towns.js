function solve(input = []) {

    let resultObj = input.reduce((acc, value, i, array) => {

        let data = value.split('<->').map(x => x.trim());

        if (!acc[`${data[0]}`]) {

            acc[`${data[0]}`] = Number(data[1]);
        }
        else {
            acc[`${data[0]}`] += Number(data[1]);
        }

        return acc;

    }, {})

    for (const key in resultObj) {
       console.log(`${key} : ${resultObj[key]}`);
       
    }
}