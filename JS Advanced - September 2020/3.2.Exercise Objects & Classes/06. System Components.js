function solve(input = []) {

    let result = input.reduce((acc, value) => {

        let [system, component, subComp] = value.split('|').map(x => x.trim());

        if (!acc[system]) {

            acc[system] = {};
        }

        if (!acc[system][component]) {

            acc[system][component] = [];
        }

        acc[system][component].push(subComp);

        return acc;

    }, {})

    let orderedObj = Object.keys(result).sort((a, b) => {

        return Object.keys(result[b]).length - Object.keys(result[a]).length || a.localeCompare(b);  

    });

    for (const system of orderedObj) {
        
        let components = Object.keys(result[system]).sort((a,b) =>{

            return result[system][b].length - result[system][a].length;
            

        });

        console.log(system);
        
        for (const component of components) {
            
            let splited = result[system][component];

            console.log(`|||${component}`);
           
            for (const item of splited) {

                console.log(`||||||${item}`);                
            }            
        }  
    }    
}