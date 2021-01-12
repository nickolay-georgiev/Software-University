(function result() {

    function add(vec1, vec2) {
        let result = [2];

        result[0] = vec1[0] + vec2[0];
        result[1] = vec2[1] + vec1[1];

        return result;
    }

    function multiply(vec1, scalar) {
        let result = [2];

        result[0] = vec1[0] * scalar;
        result[1] = vec1[1] * scalar;

        return result;
    }

    function length(vec1) {
        return Math.sqrt((vec1[0] * vec1[0]) + (vec1[1] * vec1[1]));
    }

    function dot(vec1, vec2) {
        return vec1[0] * vec2[0] + vec1[1] * vec2[1];
    }

    function cross(vec1, vec2) {
        return vec1[0] * vec1[1] - vec2[1] * vec2[0];
    }

    return {
        add,
        multiply,
        length,
        dot,
        cross
    }
})()