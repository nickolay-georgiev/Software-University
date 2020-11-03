function solve(arg1) {

    let number = Number(arg1.shift());

    while (arg1.length >  0) {

        let command = arg1.shift();

        if (command == 'chop') {
            number /= 2;
        }
        else if (command == 'dice') {
            number = Math.sqrt(number);
        }
        else if (command == 'spice') {
            number += 1;
        }
        else if (command == 'bake') {
            number *= 3;
        }
        else if (command == 'fillet') {
            number *= 0.8;
        }

        console.log(number);        
    }
}