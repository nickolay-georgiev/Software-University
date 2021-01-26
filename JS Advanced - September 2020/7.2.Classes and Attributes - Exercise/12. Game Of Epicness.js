function solve(arg1, arg2) {

    let kingdoms = {};

    for (let i = 0; i < arg1.length; i++) {

        let [kingdom, general, army] = [arg1[i].kingdom, arg1[i].general, Number(arg1[i].army)];

        if (!kingdoms[kingdom]) {

            kingdoms[kingdom] = {};
        }

        if (!kingdoms[kingdom][general]) {

            kingdoms[kingdom][general] = {
                army: 0,
                wins: 0,
                losses: 0,
            };
        }

        kingdoms[kingdom][general].army += army;
    }

    for (let i = 0; i < arg2.length; i++) {

        let [attackingKingdom, attackingGeneral, defendingKingdom, defendingGeneral] = [arg2[i][0], arg2[i][1], arg2[i][2], arg2[i][3]];

        if (attackingKingdom === defendingKingdom) {

            continue;
        }

        let firstArmy = kingdoms[attackingKingdom][attackingGeneral].army;

        let secondArmy = kingdoms[defendingKingdom][defendingGeneral].army;

        if (firstArmy > secondArmy) {

            kingdoms[attackingKingdom][attackingGeneral].army = parseInt(kingdoms[attackingKingdom][attackingGeneral].army * 1.10);
            kingdoms[attackingKingdom][attackingGeneral].wins++;

            kingdoms[defendingKingdom][defendingGeneral].army = parseInt(kingdoms[defendingKingdom][defendingGeneral].army * 0.90);
            kingdoms[defendingKingdom][defendingGeneral].losses++;

        }

        else if (secondArmy > firstArmy) {

            kingdoms[defendingKingdom][defendingGeneral].army = parseInt(kingdoms[defendingKingdom][defendingGeneral].army * 1.10);
            kingdoms[defendingKingdom][defendingGeneral].wins++;

            kingdoms[attackingKingdom][attackingGeneral].army = parseInt(kingdoms[attackingKingdom][attackingGeneral].army * 0.90);
            kingdoms[attackingKingdom][attackingGeneral].losses++;
        }
    }

    let orderedKingdoms = Object.keys(kingdoms).sort(
        (a, b) =>
            getTotal(kingdoms[b], 'wins') - getTotal(kingdoms[a], 'wins') ||
            getTotal(kingdoms[a], 'losses') - getTotal(kingdoms[b], 'losses') ||
            a.localeCompare(b)
    );

    function getTotal(kingdom, type) {
        return Object.keys(kingdom).reduce((acc, cur) => (acc + kingdom[cur][type]), 0);
    }

    let winner = orderedKingdoms[0];

    let generals = Object.keys(kingdoms[winner]).sort((a,b) => {

      return  kingdoms[winner][b].army - kingdoms[winner][a].army;
    });

    console.log(`Winner: ${orderedKingdoms[0]}`);

    generals.forEach(general => {
        let info = kingdoms[winner][general];
        console.log(`/\\general: ${general}`);
        console.log(`---army: ${info.army}`);
        console.log(`---wins: ${info.wins}`);
        console.log(`---losses: ${info.losses}`);
    });
};