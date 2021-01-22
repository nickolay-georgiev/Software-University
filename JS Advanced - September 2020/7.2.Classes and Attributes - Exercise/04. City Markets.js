function solve(input) {

    let result = {};

    for (let i = 0; i < input.length; i++) {

        let data = input[i].split(' -> ').map(x => x.trim());

        let town = data[0];
        let product = data[1];

        let [amountOfSales, priceForOneUnit] = data[2].split(':').map(x => x.trim());

        amountOfSales = Number(amountOfSales);
        priceForOneUnit = Number(priceForOneUnit);

        if (!result[town]) {
            result[town] = {};
        }
        if (!result[town][product]) {
            result[town][product] = 0;
        }

        result[town][product] += amountOfSales * priceForOneUnit;
    }

    for (let [town, value] of Object.entries(result)) {
        console.log(`Town - ${town}`);
        
        for (let [product, totalAmount] of Object.entries(value)) {
            
            console.log(`$$$${product} : ${totalAmount}`);            
        }
    }
}