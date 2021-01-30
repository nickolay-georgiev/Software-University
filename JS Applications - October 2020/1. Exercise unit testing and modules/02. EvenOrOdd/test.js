let isOddOrEven = require('./app');
let assert = require('chai').assert;

describe('isEvenOrOdd() CHECK', () => {
    it('should return undefined with value different from string.1', () => {
        let result = isOddOrEven(false);
        assert.equal(result, undefined, 'result is not undefined');
    });

    it('should return undefined with value different from string.2', () => {
        let result = isOddOrEven({});
        assert.equal(result, undefined, 'result is not undefined');
    });

    it('should return even', () => {
        let result = isOddOrEven('as');
        assert.equal(result, "even", 'result is not even');
    });

    it('should return odd', () => {
        let result = isOddOrEven('asd');
        assert.equal(result, 'odd', 'result is not odd');
    });
});