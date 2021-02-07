function attachEvents() {

    const createBtnEl = document.getElementById('btnCreate');
    const loadBtnEl = document.getElementById('btnLoad');
    const contactsSectionEl = document.getElementById('phonebook');

    const personField = document.querySelector('input#person');
    const phoneField = document.querySelector('input#phone');

    let url = 'https://phonebook-nakov.firebaseio.com/phonebook';
    const postfix = '.json';

    createBtnEl.addEventListener('click', function () {
        let person = personField.value;
        let phone = phoneField.value;

        if (!person || !phone) { return };

        createNewContact(person, phone);
        clearInputFields();
    })

    loadBtnEl.addEventListener('click', function () {
        clearLoadSection();
        loadAllContactsToLoadSection();
    })

    function clearInputFields() {
        personField.value = '';
        phoneField.value = '';
    }

    function clearLoadSection() {
        Array.from(contactsSectionEl.children).forEach(x => x.remove());
    }

    function createNewContact(person, phone) {
        fetch(url + postfix, {
            method: 'POST',
            body: JSON.stringify({ "person": person, "phone": phone })
        })
            .then(x => x.json())
            .then(x => {
                let key = x.name;
                createListItem(person, phone, key)
            });
    }

    function loadAllContactsToLoadSection() {
        return fetch(url + postfix)
            .then(x => x.json())
            .then((x) => renderInformation(x));
    }

    function renderInformation(contacts) {
        if (!contacts) { return };
        Object.keys(contacts).forEach((key) => {
            createListItem(contacts[key].person, contacts[key].phone, key);
        })
    }

    function createListItem(personName, personPhone, key) {
        let listItem = document.createElement('li');
        listItem.textContent = `${personName}: ${personPhone}`;
        contactsSectionEl.appendChild(listItem);

        let deleteBtn = document.createElement('button');
        deleteBtn.textContent = 'Delete';
        listItem.append(deleteBtn);
        contactsSectionEl.appendChild(listItem);

        deleteBtn.addEventListener('click', function () {
            let deleteUrl = `${url}/${key}${postfix}`;
            fetch(deleteUrl, {
                method: 'DELETE'
            })
                .then(response => response.json())
                .then(this.parentElement.remove());
        })
    }
}

attachEvents();