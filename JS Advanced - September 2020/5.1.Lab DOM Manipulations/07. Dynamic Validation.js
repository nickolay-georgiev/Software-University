function validate() {
    let input = document.getElementById('email');

    input.addEventListener('change', function (e) {

        input.classList.remove('error');

        if (!emailValidator(input.value)) {
            input.classList.add('error');
        }
    })

    function emailValidator(email) {

        const regex = /([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)/gm;

        return regex.test(email);
    }
}