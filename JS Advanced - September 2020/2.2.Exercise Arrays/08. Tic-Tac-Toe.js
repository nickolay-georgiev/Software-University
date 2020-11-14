function solve(arr) {

    let matrix = [[false, false, false],
    [false, false, false],
    [false, false, false]];

    let counter = arr.length;

    for (let i = 0; i < counter; i++) {

        if(i === 9){
            
            break;
        }

        let [row, col] = arr.shift().split(' ').map(x => Number(x));

        if (i % 2 == 0) {

            if (matrix[row][col] === false) {

                matrix[row][col] = 'X';

            }
            else if (matrix[row][col] === 'O' || matrix[row][col] === 'X') {

                console.log('This place is already taken. Please choose another!');
                counter--;
                i--;
            }

            let gotWinner = checkForWinner(row, col, 'X');

            if (gotWinner) {

                console.log('Player X wins!');

                PrintMatrix(matrix);
                return;
            }
        }
        else {

            if (matrix[row][col] === false) {

                matrix[row][col] = 'O';

            }
            else if (matrix[row][col] === 'X' || matrix[row][col] === 'O') {

                console.log('This place is already taken. Please choose another!');
                counter--;
                i--;
            }

            let gotWinner = checkForWinner(row, col, 'O');

            if (gotWinner) {

                console.log('Player O wins!');

                PrintMatrix(matrix);

                return;
            }

        }

    }

    console.log('The game ended! Nobody wins :(');

    PrintMatrix(matrix);
    

    function checkForWinner(row, col, player) {


        if (matrix[0][0] === player && matrix[0][1] === player && matrix[0][2] === player) {

            return true;
        }
        if (matrix[1][0] === player && matrix[1][1] === player && matrix[1][2] === player) {

            return true;
        }
        if (matrix[2][0] === player && matrix[2][1] === player && matrix[2][2] === player) {

            return true;
        }

        if (matrix[0][0] === player && matrix[1][0] === player && matrix[2][0] === player) {

            return true;
        }
        if (matrix[0][1] === player && matrix[1][1] === player && matrix[2][1] === player) {

            return true;
        }
        if (matrix[0][2] === player && matrix[1][2] === player && matrix[2][2] === player) {

            return true;
        }
        if (matrix[0][0] === player && matrix[1][1] === player && matrix[2][2] === player) {

            return true;
        }
        if (matrix[0][2] === player && matrix[1][1] === player && matrix[2][0] === player) {

            return true;
        }

        return false;

    }

    function PrintMatrix(matrix) {

        for (let i = 0; i < matrix.length; i++) {

            console.log(matrix[i].join('\t'));            
        }
    }
}
