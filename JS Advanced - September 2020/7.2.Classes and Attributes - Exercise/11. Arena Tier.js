function solve(input) {

    let gladiators = {};

    for (let i = 0; i < input.length; i++) {


        if (input[i].includes('Ave Cesar')) {

            break;
        }
        else if (input[i].includes('->')) {

            let [gladiator, technique, skill] = input[i].split(' -> ');

            skill = Number(skill);

            if (!gladiators[gladiator]) {

                gladiators[gladiator] = {
                    techniqueList: {},
                };
            }

            if (!gladiators[gladiator].techniqueList[technique]) {

                gladiators[gladiator].techniqueList[technique] = Number(skill);
            }

            if (gladiators[gladiator].techniqueList[technique] < skill) {

                gladiators[gladiator].techniqueList[technique] = skill;
            }

        }
        else if (input[i].includes(' vs ')) {

            let [firstGladiator, secondGladiator] = input[i].split(' vs ');

            if (gladiators[firstGladiator] && gladiators[secondGladiator]) {

                let firstTech = Object.keys(gladiators[firstGladiator].techniqueList);

                let secondTech = Object.keys(gladiators[secondGladiator].techniqueList);

                if (firstTech.some(x => secondTech.includes(x))) {

                    let tec = firstTech.filter(x => secondTech.includes(x));

                    if (gladiators[firstGladiator].techniqueList[tec[0]] > gladiators[secondGladiator].techniqueList[tec[0]]) {

                        delete gladiators[secondGladiator];
                    }
                    else if (gladiators[secondGladiator].techniqueList[tec[0]] > gladiators[firstGladiator].techniqueList[tec[0]]) {

                        delete gladiators[firstGladiator];
                    }
                }
            }
        }
    }

    let ordered = Object.keys(gladiators).sort((a, b) => {

        return Object.values(gladiators[b].techniqueList).reduce((d, c) => d + c) - Object.values(gladiators[a].techniqueList).reduce((d, c) => d + c) || a.localeCompare(b);
    })

    for (const gladiator of ordered) {

        let totalSkill = Object.values(gladiators[gladiator].techniqueList).reduce((a, b) => a + b);

        console.log(`${gladiator}: ${totalSkill} skill`);

        let technique = Object.keys(gladiators[gladiator].techniqueList).sort((a, b) => {

            return gladiators[gladiator].techniqueList[b] - gladiators[gladiator].techniqueList[a] || a.localeCompare(b);
        })

        for (const tec of technique) {

            console.log(`- ${tec} <!> ${gladiators[gladiator].techniqueList[tec]}`);
        }
    }
}