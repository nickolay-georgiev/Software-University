function solve(firstArg) {
    let object = {
        Monday: 1,
        Tuesday: 2,
        Wednesday: 3,
        Thursday: 4,
        Friday: 5,
        Saturday: 6,
        Sunday: 7
    };    
    console.log(object.hasOwnProperty(`${firstArg}`) ? object[`${firstArg}`] : 'error')
}