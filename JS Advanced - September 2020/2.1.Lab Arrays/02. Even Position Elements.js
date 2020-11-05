function solve(arg1) {

    let result = [];
    let counter = 0;

    for(let i = 0; i < arg1.length; i++){
        
        if(i % 2 == 0){
            result[counter] = arg1[i]; 

            counter++;
        }
    }
    console.log(result.join(" "));       
}