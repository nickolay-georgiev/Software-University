function solve() {

    const infoElement = document.getElementById('info');
    const departBtnEl = document.getElementById('depart');
    const arriveBtnEl = document.getElementById('arrive');

    let nextStationId = 'depot';
    let nextStationName = '';

    function depart() {
        let url = `https://judgetests.firebaseio.com/schedule/${nextStationId}.json`;
        displayNextStation(url);
    }

    function arrive() {
        infoElement.textContent = `Arriving at ${nextStationName}`;
        enableAndDisableButtons();
    }

    function displayNextStation(url) {
        fetch(url)
            .then(x => x.json())
            .then(x => renderResult(x))
            .then(enableAndDisableButtons());
    }

    function renderResult(obj) {
        infoElement.textContent = `Next stop ${obj.name}`;
        nextStationId = obj.next;
        nextStationName = obj.name;
    }

    function enableAndDisableButtons() {
        if (departBtnEl.disabled == true) {
            arriveBtnEl.disabled = true;
            departBtnEl.disabled = false;
        } else {
            arriveBtnEl.disabled = false;
            departBtnEl.disabled = true;
        }
    }

    return {
        depart,
        arrive
    };    
}

let result = solve();