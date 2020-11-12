function solve(input = []) {

    result = input.reduce((acc, value) => {

        let current = acc[acc.length -1];
        if(current === undefined || current <= value){

            acc.push(value);
        }

        return acc;

    },[]);
    console.log(result.join('\n'));    
}
