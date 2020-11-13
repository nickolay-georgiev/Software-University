function solve(input = []) {

    result = input.sort((a, b) => {
      return  a.length - b.length ||  a.localeCompare(b);
    })
    console.log(result.join('\n'));
}