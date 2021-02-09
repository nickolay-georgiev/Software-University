function attachEvents() {

    let weatherSymbols = {
        'Sunny': '&#x2600;',
        'Partly sunny': '&#x26C5;',
        'Overcast': '&#x2601;',
        'Rain': '&#x2614;',
        'Degrees': '&#176;'
    }

    let forecastEl = document.getElementById('forecast');
    let locationEl = document.querySelector('input#location');
    let getWeatherBtnEl = document.querySelector('input#submit');
    let currentEl = document.getElementById('current');
    let upcomingEl = document.getElementById('upcoming');

    let url = `https://judgetests.firebaseio.com/`;
    let endPoints = {
        location() { return 'locations.json' },
        forecastToday(code) { return `/forecast/today/${code}.json` },
        forecastUpcoming(code) { return `forecast/upcoming/${code}.json` },
    }

    getWeatherBtnEl.addEventListener('click', function () {
        let inputLocation = locationEl.value.toLowerCase().trim();

        let locationForecast = Promise.resolve(getLocation())
            .then(x => {
                return checkForExistingLocation(x, inputLocation);
            })
            .then(x => {
                if (!x) { return };
                return Promise.all([getTodayForecast(x.code), getUpcomingForecast(x.code)]);
            }).catch();

        Promise.resolve(locationForecast).then(x => {
            if (!x) { return };
            let todayForecast = x[0];
            let upcomingForecast = x[1];

            render(todayForecast, upcomingForecast);
        }).catch()
    })

    function render(today, upcoming) {
        renderTodayForecast(today);
        renderUpcomingForecast(upcoming);
    }

    function getUpcomingForecast(code) {
        let getUpcomingForecastUrl = url.concat(endPoints.forecastUpcoming(code));
        return fetch(getUpcomingForecastUrl)
            .then(x => x.json());
    }

    function getTodayForecast(code) {
        let getTodayForecastUrl = url.concat(endPoints.forecastToday(code));
        return fetch(getTodayForecastUrl)
            .then(x => x.json());
    }

    function getLocation() {
        let getUrl = url.concat(endPoints.location());
        return fetch(getUrl)
            .then(x => x.json());
    }

    function checkForExistingLocation(locations, inputLocation) {
        if (locations.every(location => location.name.toLowerCase() !== inputLocation)) {
            locationEl.value = 'Error';
            return;
        } else {
            return locations.find(x => x.name.toLowerCase() === inputLocation);
        }
    }

    function renderUpcomingForecast(upcoming) {
        upcomingEl.innerHTML = '';

        let div = document.createElement('div');
        div.classList.add('forecast-info');

        let divLabel = document.createElement('div');
        divLabel.classList.add('label');
        divLabel.textContent = 'Three-day forecast';

        upcoming.forecast.forEach(x => {

            let span = document.createElement('span');
            span.classList.add('upcoming');
            div.appendChild(span);

            let spanSymbol = document.createElement('span');
            spanSymbol.innerHTML = `${weatherSymbols[x.condition]}`;
            spanSymbol.classList.add('symbol');
            span.appendChild(spanSymbol);

            let spanDegrees = document.createElement('span');
            spanDegrees.innerHTML = `${x.low}${weatherSymbols.Degrees}/${x.high}${weatherSymbols.Degrees}`;
            spanDegrees.classList.add('forecast-data');
            span.appendChild(spanDegrees);

            let spanCondition = document.createElement('span');
            spanCondition.innerHTML = `${x.condition}`;
            spanCondition.classList.add('forecast-data');
            span.appendChild(spanCondition);
        })

        upcomingEl.appendChild(divLabel);
        upcomingEl.appendChild(div);
    }

    function renderTodayForecast(today) {

        currentEl.innerHTML = '';
        forecastEl.style.display = 'block';

        let div = document.createElement('div');
        div.classList.add('label');
        div.textContent = 'Current conditions';

        let currentDiv = document.createElement('div');
        currentDiv.classList.add('forecast');

        let span = document.createElement('span');
        span.setAttribute('class', 'condition symbol')
        span.innerHTML = `${weatherSymbols.Sunny}`;

        let span1 = document.createElement('span');
        span1.classList.add('condition');

        let spanCityName = document.createElement('span');
        spanCityName.classList.add('forecast-data');
        spanCityName.textContent = `${today.name}`
        span1.appendChild(spanCityName);

        let spanCurrentDegrees = document.createElement('span');
        spanCurrentDegrees.classList.add('forecast-data');
        spanCurrentDegrees.innerHTML = `${today.forecast.low}${weatherSymbols.Degrees}/${today.forecast.high}${weatherSymbols.Degrees}`
        span1.appendChild(spanCurrentDegrees);

        let spanCondition = document.createElement('span');
        spanCondition.classList.add('forecast-data');
        spanCondition.innerHTML = `${today.forecast.condition}`
        span1.appendChild(spanCondition);

        currentDiv.appendChild(span);
        currentDiv.appendChild(span1);

        currentEl.appendChild(div);
        currentEl.appendChild(currentDiv);
    }
}

attachEvents();