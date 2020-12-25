function solve() {

    let button = document.querySelector('#exercise  article  button');

    button.addEventListener('click', function (e) {

        let input = document.querySelector('#exercise  article  input[type=text]').value.toLowerCase();

        if (input === ''  input.charCodeAt(0)  97  input.charCodeAt(0)  122) { return };

        let data = Array.from(document.querySelector('ol').querySelectorAll('li'));

        let indexItem = input.charCodeAt(0) - 97;

        let item = data[indexItem];

        input = input.charAt(0).toUpperCase() + input.substr(1);

        if (item.textContent === '') {

            item.textContent = input;

        } else {

            let currentText = item.textContent.split(', ');

            currentText.push(input);

            item.textContent = currentText.join(', ');
        }

        document.querySelector('#exercise  article  input[type=text]').value = '';
    })
}