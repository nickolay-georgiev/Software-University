function solve(firstArg) {

    if (typeof firstArg === "number") {

        for (let i = 1; i <= firstArg; i++) {
            
            let result = '*'.repeat(firstArg);

            console.log(Array.from(result).join(" "));

        }
    }
    else {
        for (let i = 1; i <= 5; i++) {

            let result = '*'.repeat(5);

            console.log(Array.from(result).join(" "));
        }
    }
}