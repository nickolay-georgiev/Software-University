function solve(firstArg) {
    let numberAsString = firstArg.toString();
    let numberAsStringArray = Array.from(numberAsString);

    console.log(numberAsStringArray.every(x => x == numberAsStringArray[0]) ? 'true' : 'false');
    console.log(numberAsStringArray.map(x=> Number(x)).reduce((a, b) => a + b));    
}