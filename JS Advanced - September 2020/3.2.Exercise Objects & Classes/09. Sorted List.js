class List {

    constructor() {

        this.arr = [];
        this.size = 0;
    }

    add(n) {
        this.arr.push(n);
        this.arr.sort((a, b) => a - b);
        this.size++;
    };

    remove(index) {
        if (index >= 0 && index < this.arr.length) {

            this.arr.splice(index, 1);

            this.arr.sort((a, b) => { a - b });

            this.size--;
        }
    }

    get(index) {

        if (index >= 0 && index < this.arr.length) {

            this.arr.sort((a, b) => { a - b });

            return this.arr[index];

        }
    }
}
