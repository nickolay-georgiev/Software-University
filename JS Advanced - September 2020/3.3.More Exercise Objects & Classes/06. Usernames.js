function solve(input) {    
    let usernames = [...new Set(input)].sort((a,b) => {
        return a.length - b.length || a.localeCompare(b);
    });
    console.log(usernames.join('\n'));   
}