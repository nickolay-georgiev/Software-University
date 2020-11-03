function solve(arg1) {

    let km = arg1.shift();
    let area = arg1.shift();

    let radar = new Map();

    radar.set('motorway', 130);
    radar.set('interstate', 90);
    radar.set('city', 50);
    radar.set('residential', 20);

    let result = '';

    if (km > radar.get(area) && km <= radar.get(area) + 20) {
        result = 'speeding';
        console.log(result);
    }

    else if (km > radar.get(area) && km <= radar.get(area) + 40) {
        result = 'excessive speeding';
        console.log(result);
    }

    else if (km > radar.get(area) && km >= radar.get(area) + 41) {
        result = 'reckless driving';
        console.log(result);
    }
}