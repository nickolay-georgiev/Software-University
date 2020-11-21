function solve(params = []) {

    let result = params.reduce((acc, value) => {

        let data = value.split('/').map(x => x.trim());

        let name = data[0];
        let level = Number(data[1]);
        let dataItems = data[2] ? data[2].split(',').map(x => x.trim()) : [];

        obj = {
            name: name,
            level: level,
            items: dataItems,
        };

        acc.push(obj);

        return acc;
    }, [])

    console.log(JSON.stringify(result));
}