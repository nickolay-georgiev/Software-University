function solve(firstArg) {
    result = typeof(firstArg) === 'number' 
	? (Math.PI * Math.pow(firstArg, 2)).toFixed(2) 
	: `We can not calculate the circle area, because we receive a ${typeof(firstArg)}.`;
    console.log(result);
}