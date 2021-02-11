
const urlPaths = {
    create: () => `https://books-4e8bf.firebaseio.com/books.json`,
    getAll: () => `https://books-4e8bf.firebaseio.com/books.json`,
    update: (id) => `https://books-4e8bf.firebaseio.com/books/${id}.json`,
    delete: (id) => `https://books-4e8bf.firebaseio.com/books/${id}.json`
}

export async function getBooks() {
    let response = await fetch(urlPaths.getAll());
    let data = await response.json();
    data = Object.entries(data);
    return data;
}

export async function createBook(book) {
    let response = await fetch(urlPaths.create(), {
        method: 'POST',
        body: JSON.stringify(book),
        headers: {
            "Content-Type": "application/json"
        }
    });
    let data = await response.json();
    return data;
}

export async function updateBook(book) {
    let response = await fetch(urlPaths.update(book.objectId), {
        method: 'PUT',
        body: JSON.stringify(book),
        headers: {
            "Content-Type": "application/json"
        }
    });
    let data = await response.json();
    return data;
}

export async function deleteBook(book) {
    let response = await fetch(urlPaths.delete(book[0]), {
        method: 'DELETE',
    });
    let data = await response.json();
    return data;
}