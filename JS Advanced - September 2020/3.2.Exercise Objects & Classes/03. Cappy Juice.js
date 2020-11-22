function solve(input) {

    let resultOrder = {};

    let result = {};


    for (let i = 0; i < input.length; i++) {

        let [juiceType, quantity] = input[i].split('=>').map(x => x.trim());

        if (!result[`${juiceType}`]) {

            result[`${juiceType}`] = Number(quantity);
        }
        else {

            result[`${juiceType}`] += Number(quantity);
        }

        if(result[`${juiceType}`] >= 1000){

            resultOrder[`${juiceType}`] = 0;
        }

    }

    for (const key in resultOrder) {
        
        for (const key1 in result) {
        
            if(key == key1){

                resultOrder[key] += parseInt(result[key1] / 1000);
            }            
        }        
    }

    for (const key in resultOrder) {
        
        console.log(`${key} => ${resultOrder[key]}`);
               
    }    
}