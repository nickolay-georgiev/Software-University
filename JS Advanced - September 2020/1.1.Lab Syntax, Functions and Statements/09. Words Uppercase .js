function solve(firstArg) {

    const regex = /\w+/gm;
    const str = firstArg;
    let m;

    let result = [];
    while ((m = regex.exec(str)) !== null) {

        if (m.index === regex.lastIndex) {
            regex.lastIndex++;
        }

        m.forEach((match, groupIndex) => {
            result.push(`${match.toUpperCase()}`);
        });
    }    

    console.log(result.join(', '));
}