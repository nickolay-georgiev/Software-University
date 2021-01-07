function solve() {

    let allCells = Array.from(document.querySelectorAll('tbody > tr'));

    let quickCheckButton = Array.from(document.getElementsByTagName('button'))[0];
    let clearButton = Array.from(document.getElementsByTagName('button'))[1];

    let resultField = document.querySelector('#check > p');

    let tableBorder = document.getElementById('exercise').firstElementChild;

    quickCheckButton.addEventListener('click', function (e) {

        let matrix = [];
        for (let i = 0; i < allCells.length; i++) {

            let allCols = Array.from(allCells[i].children);

            matrix[i] = new Array(allCells.length);

            for (let j = 0; j < allCols.length; j++) {

                let currentCellValue = Number(allCols[j].firstElementChild.value);

                let minAllowedValue = Number(allCols[j].firstElementChild.min);
                let maxAllowedValue = Number(allCols[j].firstElementChild.max);

                let isNumberAllowed = checkForNotAllowdedNumber(currentCellValue, maxAllowedValue, minAllowedValue);

                if(isNumberAllowed === false){
                    printGameOverStatistic();
                    return;
                }

                matrix[i][j] = currentCellValue;
            }
        }

        for (let i = 0; i < matrix.length; i++) {

            let unique = matrix[i].filter(checkForOnlyUniqueNumbers)

            if (unique.length < matrix[i].length) {

                printGameOverStatistic();
                return;
            }
        }

        for (let i = 0; i < matrix.length; i++) {

            let tempArray = [];
            for (let j = 0; j < matrix[i].length; j++) {

                let currentNumber = matrix[j][i];

                tempArray.push(currentNumber);
            }

            let unique = tempArray.filter(checkForOnlyUniqueNumbers)
            if (unique.length < matrix[i].length) {

                printGameOverStatistic();
                return;
            }
        }

        printYouWonSudomuStatistic();
    })

    clearButton.addEventListener('click', function(e){

        resultField.textContent = '';
        tableBorder.style.border = "none";

        for (let i = 0; i < allCells.length; i++) {

            let allCols = Array.from(allCells[i].children);

            for (let j = 0; j < allCols.length; j++) {

                allCols[j].firstElementChild.value = '';
            }
        }
    })

    function printYouWonSudomuStatistic() {
        resultField.textContent = 'You solve it! Congratulations!';
        resultField.style.color = 'green';
        tableBorder.style.border = "2px solid green";
    }

    function printGameOverStatistic() {
        resultField.textContent = 'NOP! You are not done yet...';
        resultField.style.color = 'red';
        tableBorder.style.border = "2px solid red";
    }

    function checkForNotAllowdedNumber(currentCellValue, maxAllowedValue, minAllowedValue) {
        if (currentCellValue > maxAllowedValue || currentCellValue < minAllowedValue) {
           return false;
        }
        return true;
    }

    function checkForOnlyUniqueNumbers(value, index, self) {
        return self.indexOf(value) === index;
    }
}