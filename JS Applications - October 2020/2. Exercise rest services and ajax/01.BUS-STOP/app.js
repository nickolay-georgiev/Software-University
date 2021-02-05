function getInfo(e) {

    const validIds = ['1287', '1308', '1327', '2334']

    const stopNameEl = document.getElementById('stopName');
    const busesEl = document.getElementById('buses');

    let stopId = document.getElementById('stopId').value;
    if (!validIds.includes(stopId)) {
        removeListItems(busesEl);
        stopNameEl.textContent = 'Error';
        return;
    }

    let url = `https://judgetests.firebaseio.com/businfo/${stopId}.json`;
    
    fetch(url)
        .then(x => x.json())
        .then(x => renderInfo(x));

    function renderInfo(data) {
        removeListItems(busesEl);

        let stationName = data.name;
        stopNameEl.textContent = stationName;

        Object.entries(data.buses).reduce((acc, value) => {
            let listItem = document.createElement('li');
            listItem.textContent = `Bus ${value[0]} arrives in ${value[1]} minutes`;
            busesEl.appendChild(listItem);
        }, 0);
    }

    function removeListItems(domElement) {
        Array.from(domElement.children).forEach(x => x.remove());
    }
}