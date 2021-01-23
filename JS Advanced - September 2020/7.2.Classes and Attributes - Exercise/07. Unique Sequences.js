function sum(input) {
 
    let stored = new Set();
 
    for (let user of input)
    {
        let sor = JSON.parse(user).sort((a,b)=>b-a);
        stored.add(JSON.stringify(sor));
    }
 
    let res = [];
    [...stored].forEach(f=>res.push(JSON.parse(f)));
 
    res.sort((a,b)=> a.length-b.length);
 
    res.forEach(f=> console.log(`[${f.join(', ')}]`));
 
}