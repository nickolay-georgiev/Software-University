function solve(arr) {

    let counter = 0;
    let matrix = [[]];

    for (let i = 0; i < arr.length; i++) {

        let data = arr[i].split(' ').filter(x => x.trim()).map(Number);

        matrix[i] = [];

        for (let j = 0; j < data.length; j++) {

            matrix[counter][j] = data[j];
        }

        counter++
    }

    let sumFirstDiagonal = 0;
    let sumSecondDiagonal = 0;

    counter = 0;

    for (let i = 0; i < matrix.length; i++) {

        sumFirstDiagonal += matrix[i][counter++];
    }

    counter = matrix.length - 1;

    for (let i = 0; i < matrix.length; i++) {

        sumSecondDiagonal += matrix[i][counter--];
    }

    if (sumFirstDiagonal == sumSecondDiagonal) {

        let row = 0;
        let col = 0;

        let test1 = matrix.length -1;

        for (let i = 0; i < matrix.length; i++) {
            
            for (let j = 0; j < matrix.length; j++) {
                
                if (i != row || j != col && j != test1) {
                    
                    matrix[i][j] = sumFirstDiagonal;
                }

            }

            test1--;
            col++;
            row++;
        }

    }

    for (let i = 0; i < matrix.length; i++) {

        console.log(matrix[i].join(' '));
    }

}