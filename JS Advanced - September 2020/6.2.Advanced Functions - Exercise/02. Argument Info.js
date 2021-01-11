function solve() {

    let dataTypes = {};

    for (const arg of arguments) {

        if (!dataTypes[typeof arg]) {
            dataTypes[typeof arg] = 0;
        }

        console.log(`${typeof arg}: ${arg}`);
        dataTypes[typeof arg]++;
    }

    Object.entries(dataTypes).sort((a, b) => b[1] - a[1]).forEach(x => console.log(`${x[0]} = ${x[1]}`));
}