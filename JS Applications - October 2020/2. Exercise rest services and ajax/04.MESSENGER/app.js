function attachEvents() {

    const messagesAreaEl = document.getElementById('messages');
    const authorEl = document.getElementById('author');
    const contentEl = document.getElementById('content');

    const sendBtn = document.getElementById('submit');
    const refreshBtn = document.getElementById('refresh');

    let url = `https://rest-messanger.firebaseio.com/messanger`;
    const postfix = '.json';

    sendBtn.addEventListener('click', function () {
        let author = authorEl.value;
        let content = contentEl.value;

        if (!author || !content) { return };

        fetch(url + postfix, {
            method: 'POST',
            body: JSON.stringify({ author, content })
        })
            .then(x => x.json());

        clearInputFields();
    })

    refreshBtn.addEventListener('click', function () {
        messagesAreaEl.textContent = '';
        fetch(url + postfix)
            .then(x => x.json())
            .then(x => renderAllMessages(x));
    })

    function renderAllMessages(messages) {
        Object.keys(messages).map((x) => {
            messagesAreaEl.textContent += `${messages[x].author}: ${messages[x].content}` + '\n';
        })
    }

    function clearInputFields() {
        authorEl.value = '';
        contentEl.value = '';
    }
}

attachEvents();