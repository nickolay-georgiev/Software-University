function solve(inputName, inputAge, inputWeight, inputHeight) {

    let name = inputName;
    let age = Number(inputAge);
    let weight = Number(inputWeight);
    let height = Number(inputHeight);

    let bmi = Math.round(weight / (height / 100 * height / 100));

    let bmiStatus = {
        18.5: 'underweight',
        25: 'normal',
        30: 'overweight',
    }

    let patient = {
        name,
        personalInfo: {
            age,
            weight,
            height,
        },
        BMI: bmi,
        status: '',
    }

    for (const item of Object.entries(bmiStatus).sort((a, b) => a[0] - b[0])) {

        if (Number(item[0]) > bmi) {
            patient.status = item[1];
            break;
        }
        else if (bmi >= 30) {
            patient.status = 'obese';
            patient.recommendation = 'admission required';
            break;
        }
    }

    //debugger
    //console.log(JSON.stringify(patient));

    return patient;
}
