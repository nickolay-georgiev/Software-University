function attachEventsListeners() {

    let outputResults = {
        'Days': 0,
        'Hours': 0,
        'Minutes': 0,
        'Seconds': 0,
    }

    let functionsToConvertInputToDays = {
        'Days': (x) => { return x * 1 },
        'Hours': (x) => { return x / 24 },
        'Minutes': (x) => { return x / 1440 },
        'Seconds': (x) => { return x / 86400 },
    }

    let inputFields = [...document.querySelectorAll('input')].reduce((acc, value, i) => {

        if (i % 2 === 1) { acc.push(value) }
        return acc;
    }, [])

    let outputFields = [...document.querySelectorAll('input')].reduce((acc, value, i) => {

        if (i % 2 === 0) { acc.push(value) }
        return acc;
    }, [])

    inputFields.forEach(x => x.addEventListener('click', eventHandler));

    function eventHandler(e) {

        let inputValue = Number(e.target.previousElementSibling.value);

        let unformatedPeriod = e.target.previousElementSibling.previousElementSibling.textContent;

        let period = unformatedPeriod.trim().substring(0, unformatedPeriod.length - 2)

        let func = functionsToConvertInputToDays[period];

        let convertInputToDays = func(inputValue);

        outputResults['Days'] = convertInputToDays * 1;
        outputResults['Hours'] = convertInputToDays * 24;
        outputResults['Minutes'] = convertInputToDays * 1440;
        outputResults['Seconds'] = convertInputToDays * 86400;

        let outputResultKeys = Object.keys(outputResults);

        for(let i = 0; i < outputFields.length; i++){

            outputFields[i].value = outputResults[outputResultKeys[i]];
        }
    }
}