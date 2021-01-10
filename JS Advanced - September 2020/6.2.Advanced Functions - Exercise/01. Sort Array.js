function solve(inputArr, criteria) {
    let sortedFunctions = {
        asc: function (arr) { return arr.sort((a, b) => a - b) },
        desc: function (arr) { return arr.sort((a, b) => b - a) }
    }

    let func = sortedFunctions[criteria];
    return func(inputArr);
}