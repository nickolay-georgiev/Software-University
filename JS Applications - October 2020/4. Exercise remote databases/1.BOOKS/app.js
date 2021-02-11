import { deleteBook, createBook, updateBook, getBooks } from './data.js'

window.addEventListener('load', () => {

    const submitBtnEl = document.querySelector('body > form > button');
    const loadBtnEl = document.getElementById('loadBooks');
    const tBodyEl = document.querySelector('body > table > tbody');
    tBodyEl.innerHTML = '';

    const titleEl = document.getElementById('title');
    const authorEl = document.getElementById('author');
    const isbnEl = document.getElementById('isbn');

    submitBtnEl.addEventListener('click', submitHandler);
    loadBtnEl.addEventListener('click', loadBtnHandler)

    async function submitHandler(e) {
        e.preventDefault();
        loadBtnEl.disabled = false;
        let dataInput = {
            title: document.getElementById('title'),
            author: document.getElementById('author'),
            isbn: document.getElementById('isbn'),
        }

        let allInputsAreValid = validateInput(dataInput);
        if (!allInputsAreValid) { alert('All fields are required :) !!!'); return }

        let book = {
            title: titleEl.value.trim(),
            author: authorEl.value.trim(),
            isbn: isbnEl.value.trim()   
        }
        await createBook(book);

        titleEl.value = '';
        authorEl.value = '';
        isbnEl.value = '';
    }

    async function loadBtnHandler() {
        loadBtnEl.disabled = true;
        let books = await getBooks();
        Object.values(books).forEach(x => {
            renderBook(x);
        })
    }

    function renderBook(book) {
        if (Array.from(tBodyEl.children).some(x => x.getAttribute('id') == book[0])) {
            return;
        }

        let tr = document.createElement('tr');
        tr.setAttribute('id', `${book[0]}`)

        let tdTitle = document.createElement('td');
        tdTitle.textContent = book[1].title;

        let tdAuthor = document.createElement('td');
        tdAuthor.textContent = book[1].author;

        let tdIsbn = document.createElement('td');
        tdIsbn.textContent = book[1].isbn;

        let editBtn = document.createElement('button');
        editBtn.textContent = 'Edit';

        let deleteBtn = document.createElement('button');
        deleteBtn.textContent = 'Delete';

        tr.append(tdTitle, tdAuthor, tdIsbn, editBtn, deleteBtn);
        tBodyEl.appendChild(tr);

        deleteBtn.addEventListener('click', deleteBtnHandler)
        editBtn.addEventListener('click', editBtnHandler)

        async function deleteBtnHandler() {
            await deleteBook(book);
            this.parentElement.remove();
        }

        function editBtnHandler() {
            let tableData = Array.from(this.parentElement.children);
            let newTr = document.createElement('tr');

            let tdTit = document.createElement('td');
            let inputTit = document.createElement('input');
            inputTit.setAttribute('type', 'text');
            inputTit.value = tableData[0].textContent;
            tdTit.appendChild(inputTit);

            let tdAuth = document.createElement('td');
            let inputAuth = document.createElement('input');
            inputAuth.setAttribute('type', 'text');
            inputAuth.value = tableData[1].textContent;
            tdAuth.appendChild(inputAuth);

            let tdIsb = document.createElement('td');
            let inputIsb = document.createElement('input');
            inputIsb.setAttribute('type', 'text');
            inputIsb.value = tableData[2].textContent;
            tdIsb.appendChild(inputIsb);

            let saveBtn = document.createElement('button');
            saveBtn.textContent = 'Save';

            let cancelBtn = document.createElement('button');
            cancelBtn.textContent = 'Cancel';

            newTr.append(tdTit, tdAuth, tdIsb, saveBtn, cancelBtn);
            this.parentElement.replaceWith(newTr);

            cancelBtn.addEventListener('click', cancelHandler)
            saveBtn.addEventListener('click', saveBtnHandler);

            async function saveBtnHandler() {
                let updatedBook = {
                    title: this.parentElement.children[0].firstElementChild.value.trim(),
                    author: this.parentElement.children[1].firstElementChild.value.trim(),
                    isbn: this.parentElement.children[2].firstElementChild.value.trim(),
                    objectId: book.objectId
                }

                let obj = {
                    title: this.parentElement.children[0].firstElementChild,
                    author: this.parentElement.children[1].firstElementChild,
                    isbn: this.parentElement.children[2].firstElementChild,
                }

                let allUpdatesAreValid = validateInput(obj);
                if (!allUpdatesAreValid) { alert('All fields are required :) !!!'); return }

                tdTitle.textContent = updatedBook.title;
                tdAuthor.textContent = updatedBook.author;
                tdIsbn.textContent = updatedBook.isbn;

                await updateBook(updatedBook);
                this.parentElement.replaceWith(tr);
            }
        }
        function cancelHandler() {
            this.parentElement.replaceWith(tr);
        }
    }

    function validateInput(dataInput) {
        let allFieldsAreValid = true;
        Object.values(dataInput).forEach(x => {
            if (!x.value.trim()) {
                x.classList.add('emptyInput');
                allFieldsAreValid = false;
            } else {
                x.classList.remove('emptyInput')
            }
        })

        return allFieldsAreValid;
    }
})