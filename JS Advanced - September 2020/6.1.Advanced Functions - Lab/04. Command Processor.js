function solution() {
    let data = '';

    function append(string) {
        data = data.concat(string);
    }

    function removeStart(n) {
        data = data.slice(n, data.length);
    }

    function removeEnd(n) {
        data = data.slice(0, -n);
    }

    function print() {
        console.log(data);
    }

    return {
        append,
        removeStart,
        removeEnd,
        print
    }
}