function solve(input = []) {

    let result = [];

    for (let index = 0; index < input.length; index++) {

        let data = input[index].split('|').map(x => x.trim()).filter(x => x != '');

        let towns = {};
        if (index == 0) {
            var town = data[0];
            var latitude = data[1];
            var longitude = data[2];
        }
        else {
            let townName = data[0];
            let latitudeValue = Number(data[1]) == 0 ? 0 : Number(data[1]).toFixed(2);
            let longitudeValue = Number(data[2]) == 0 ? 0 : Number(data[2]).toFixed(2);

            let tempAtt = latitudeValue.toString();

            if(tempAtt[tempAtt.length -1] == 0 && tempAtt.length != 1)
            {
                latitudeValue = Number(data[1]).toFixed(1);
            }
            tempAtt = longitudeValue.toString();

            if(tempAtt[tempAtt.length -1] == 0 && tempAtt.length != 1)
            {
                longitudeValue = Number(data[1]).toFixed(1);
            }


            result.push(`{\"${town}\":\"${townName}\",\"${latitude}\":${latitudeValue},\"${longitude}\":${longitudeValue}}`);
        }

    }

    console.log(`[${result.join(",")}]`);

}