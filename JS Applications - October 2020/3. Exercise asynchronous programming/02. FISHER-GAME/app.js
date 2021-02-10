function attachEvents() {
    
    let url = `https://fisher-game.firebaseio.com/catches`;
    const endPoints = {
        createCatch() { return '.json' },
        getCathes() { return '.json' },
        updateCatch(catchId) { return `/${catchId}.json` },
        deleteCatch(catchId) { return `/${catchId}.json` },
    }

    const catchesEl = document.getElementById('catches');
    const anglerEl = document.querySelector('#addForm > input.angler');
    const weightEl = document.querySelector('#addForm > input.weight');
    const speciesEl = document.querySelector('#addForm > input.species');
    const locationEl = document.querySelector('#addForm > input.location');
    const baitEl = document.querySelector('#addForm > input.bait');
    const captureTimeEl = document.querySelector('#addForm > input.captureTime');

    const loadBtnEl = document.querySelector('body > aside > button');
    const addBtnEl = document.querySelector('#addForm > button.add');

    addBtnEl.addEventListener('click', function () {

        let angler = anglerEl.value;
        let weight = weightEl.value;
        let species = speciesEl.value;
        let location = locationEl.value;
        let bait = baitEl.value;
        let captureTime = captureTimeEl.value;

        if (!angler || !weight || !species || !location || !bait || !captureTime) {
            return;
        }

        let currentCatch = {
            angler,
            weight,
            species,
            location,
            bait,
            captureTime
        }

        Promise.resolve(createNewCatch(currentCatch))
            .then(x => appendNewCatchToCathesSection(x, currentCatch))

    })

    function appendNewCatchToCathesSection(element, currentCatch) {

        let id = element.name || element;

        if (Array.from(catchesEl.children).some(x => x.getAttribute('data-id') === id)) {
            return;
        }

        let div = document.createElement('div');
        div.classList.add('catch');
        div.setAttribute('data-id', `${id}`);

        div.innerHTML = `
        <label>Angler</label>
        <input type="text" class="angler" value="${currentCatch.angler}">
        <hr>
        <label>Weight</label>      
        <input type="number" class="weight" value="${currentCatch.weight}">
        <hr>
        <label>Species</label>
        <input type="text" class="species" value="${currentCatch.species}">
        <hr>
        <label>Location</label>
        <input type="text" class="location" value="${currentCatch.location}">
        <hr>
        <label>Bait</label>
        <input type="text" class="bait" value="${currentCatch.bait}">
        <hr>
        <label>Capture Time</label>
        <input type="number" class="captureTime" value="${currentCatch.captureTime}">
        <hr>
    </div>`;

        let updateBtn = document.createElement('button');
        updateBtn.classList.add('update');
        updateBtn.textContent = 'Update';
        div.appendChild(updateBtn);

        let deleteBtn = document.createElement('button');
        deleteBtn.classList.add('delete');
        deleteBtn.textContent = 'Delete';
        div.appendChild(deleteBtn);

        catchesEl.appendChild(div);

        deleteBtn.addEventListener('click', function () {
            let ids = this.parentElement.getAttribute('data-id')
            this.parentElement.remove();
            Promise.resolve(deleteCatch(ids))
                .then(this.parentElement.remove());
        });

        updateBtn.addEventListener('click', function () {
            let updateCatchId = this.parentElement.getAttribute('data-id')
            let updateCatch = {
                angler: this.parentElement.querySelector('.angler').value,
                weight: this.parentElement.querySelector('.weight').value,
                species: this.parentElement.querySelector('.species').value,
                location: this.parentElement.querySelector('.location').value,
                bait: this.parentElement.querySelector('.bait').value,
                captureTime: this.parentElement.querySelector('.captureTime').value
            }
            updateCatchesSection(updateCatchId, updateCatch)
        })
    }

    function updateCatchesSection(id, updatedCatch) {
        let updateUrl = url.concat(endPoints.updateCatch(id));

        fetch(updateUrl, {
            method: 'PUT',
            headers: {
                "Content-type": "application/json"
            },
            body: JSON.stringify({ ...updatedCatch })
        })
    }

    loadBtnEl.addEventListener('click', function () {
        Promise.resolve(loadAllCatches())
            .then(x => {
                if (!x) { return }
                Object.entries(x).forEach(currentCatch => {
                    appendNewCatchToCathesSection(currentCatch[0], currentCatch[1]);
                })
            });
    });

    function loadAllCatches() {
        let loadAllUrl = url.concat(endPoints.getCathes());
        return fetch(loadAllUrl)
            .then(x => x.json());
    }

    function deleteCatch(id) {
        let deleteUrl = url.concat(endPoints.deleteCatch(id));
        return fetch(deleteUrl, {
            method: 'DELETE',
        });
    }

    function createNewCatch(obj) {
        let createUrl = url.concat(endPoints.createCatch());
        return fetch(createUrl, {
            method: 'POST',
            body: JSON.stringify({ ...obj })
        }).then(x => x.json());
    }
}

attachEvents();

