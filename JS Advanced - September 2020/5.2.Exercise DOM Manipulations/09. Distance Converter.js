function attachEventsListeners() {

    let inputConverterToMeters = {
        'Kilometers': (x) => x * 1000,
        'Meters': (x) => x * 1,
        'Centimeters': (x) => x * 0.01,
        'Millimeters': (x) => x * 0.001,
        'Miles': (x) => x * 1609.34,
        'Yards': (x) => x * 0.9144,
        'Feet': (x) => x * 0.3048,
        'Inches': (x) => x * 0.0254,
    }

    let outputResults = {
        'Kilometers': (x) => x / 1000,
        'Meters': (x) => x * 1,
        'Centimeters': (x) => x / 0.01,
        'Millimeters': (x) => x / 0.001,
        'Miles': (x) => x / 1609.34,
        'Yards': (x) => x / 0.9144,
        'Feet': (x) => x / 0.3048,
        'Inches': (x) => x / 0.0254,
    }

    let convertButton = document.getElementById('convert');
    let inputValueField = document.getElementById('inputDistance');
    let outputValueField = document.getElementById('outputDistance');

    let inputUnits = Array.from(document.getElementById('inputUnits').children);
    let outputUnits = Array.from(document.getElementById('outputUnits').children);

    convertButton.addEventListener('click', function (e) {

        let inputValue = Number(inputValueField.value);
        let inputUnit = inputUnits.find(x => x.selected === true).textContent;

        let func = inputConverterToMeters[inputUnit];
        let convertedValueToMeters = func(inputValue);

        console.log(convertedValueToMeters);

        let outputUnit = outputUnits.find(x => x.selected === true).textContent;

        let resultFunction = outputResults[outputUnit];
        let result = resultFunction(convertedValueToMeters)

        outputValueField.value = result;
    })
}