
class Rat {

    constructor(name) {

        this.name = name;
        this.unitedRats = [];
    }

    toString() {

        let result;

        if (this.unitedRats.length == 0) {

            result = this.name;
        }
        else {

            result = this.name + '\n';

            for (const rat of this.unitedRats) {

                result += `##${rat.name}\n`
            }
        }

        return result;

    };

    getRats() { return this.unitedRats }

    unite(rat) {

        if (rat instanceof Rat) {

            this.unitedRats.push(rat);
        }
    };
}