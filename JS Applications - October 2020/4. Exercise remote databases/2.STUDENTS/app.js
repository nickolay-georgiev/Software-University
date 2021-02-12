const html = {
    tableBody: () => document.querySelector("tbody"),
    submitBtn: () => document.querySelector(".submit"),
    refreshBtn: () => document.querySelector(".refresh"),
    firstName: () => document.querySelector("#firstName"),
    lastName: () => document.querySelector("#lastName"),
    facultyNumber: () => document.querySelector("#facultyNumber"),
    grade: () => document.querySelector("#grade"),
};

let url = `https://students-12658.firebaseio.com/students.json`;
async function solve() {
    const response = await fetch(url);
    const data = await response.json();
    if (!data) { return };
    let students = Object.values(data);

    html.tableBody().innerHTML = '';
    students.sort((a, b) => { return a.id - b.id })
        .forEach(s => {
            const tr = document.createElement("tr");
            const id = document.createElement("th");
            const firstName = document.createElement("th");
            const lastName = document.createElement("th");
            const facultyNumber = document.createElement("th");
            const grade = document.createElement("th");

            tr.id = s.objectId;
            id.textContent = s.id;
            firstName.textContent = s.firstName;
            lastName.textContent = s.lastName;
            facultyNumber.textContent = s.facultyNumber;
            grade.textContent = s.grade.toFixed(2);

            tr.append(id, firstName, lastName, facultyNumber, grade);
            html.tableBody().append(tr);
        });
}

async function createStudent(student) {
    let response = await fetch(url, {
        method: 'POST',
        body: JSON.stringify(student),
        headers: {
            "Content-Type": "application/json"
        }
    }).catch(err => {
        alert(err)
    });
    let data = await response.json();
    return data;
}

html.submitBtn().addEventListener('click', async (e) => {
    e.preventDefault();

    let firstName = html.firstName().value;
    let lastName = html.lastName().value;
    let facultyNumber = html.facultyNumber().value;
    let grade = Number(html.grade().value);

    if (!firstName || !lastName || !facultyNumber || !grade) {
        alert("All fields are required!");
        return;
    }

    const response = await fetch(url);
    const data = await response.json();
    let idCounter = data ? Object.keys(data).length + 1 : 1;

    let student = {
        id: idCounter,
        firstName,
        lastName,
        facultyNumber,
        grade,
    }

    createStudent(student);

    html.firstName().value = '';
    html.lastName().value = '';
    html.facultyNumber().value = '';
    html.grade().value = '';
})

html.refreshBtn().addEventListener('click', (e) => {
    e.preventDefault();
    solve();
})

solve();