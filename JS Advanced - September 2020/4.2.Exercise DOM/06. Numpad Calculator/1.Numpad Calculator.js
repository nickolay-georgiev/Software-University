function solve() {

    let inputArea = document.querySelector('#calculator > div.keys');
    let inputField = document.getElementById('expressionOutput');
    let resultField = document.getElementById('resultOutput');
    let clearButton = document.querySelector('#calculator > div.top > button');

    let operations = {
        '/': (a, b) => a / b,
        'x': (a, b) => a * b,
        '-': (a, b) => a - b,
        '+': (a, b) => a + b,
    }

    let firstNumber = '';
    let secondNumber = '';
    let currentFunc;
    let firstNumberIsReady = false;

    clearButton.addEventListener('click', function (e) {

        resultField.textContent = '';
        inputField.textContent = '';

        firstNumber = '';
        secondNumber = '';
        currentFunc;
        firstNumberIsReady = false;
    })

    inputArea.addEventListener('click', function (e) {

        inputValue = e.target.textContent;
        let keys = Object.keys(operations);

        if (inputValue === '=') {

            if (firstNumber === '' || secondNumber === '') {
                resultField.textContent = NaN;

                return;
            }

            let result = currentFunc(Number(firstNumber.trim()), Number(secondNumber.trim()));

            resultField.textContent = result;

            return;
        }
        else if (keys.some(x => x === inputValue)) {

            firstNumberIsReady = true;
            inputField.textContent += " ";
            inputValue += ' ';

            currentFunc = operations[inputValue.trim()];
        } else if (firstNumberIsReady === false) {

            firstNumber += inputValue;

        } else {

            secondNumber += inputValue;
        }

        inputField.textContent += inputValue;
    })
}