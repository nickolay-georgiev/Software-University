function solve(params) {
    let stat = new Map();

    for (const row of params) {
        let [town, product, price] = row.split('|').map(e => e.trim());

        if (!stat.get(product)) {
            stat.set(product, new Map());
        }

        stat.get(product).set(town, Number(price));
    }

    let result = "";

    for (const productWithPrice of stat) {
        let lowestPrice = [...productWithPrice[1]].sort((a, b) => a[1] - b[1])[0]; // [a, [b, c]]
        result += `${productWithPrice[0]} -> ${lowestPrice[1]} (${lowestPrice[0]})\n`;
    }

    console.log(result.trim());
}