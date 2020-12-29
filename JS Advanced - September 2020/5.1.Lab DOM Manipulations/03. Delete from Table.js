function deleteByEmail() {

    let inputEmail = document.querySelector('body > label > input[type=text]').value.trim();
    let resultDiv = document.getElementById('result');

    let tableData = Array.from(document.querySelectorAll('td'));

    for (let i = 1; i < tableData.length; i += 2) {

        if (inputEmail === tableData[i].textContent) {

            tableData[i].parentElement.remove();
            resultDiv.textContent = 'Deleted';
            return;
        }
    }

    resultDiv.textContent = 'Not found.';
}