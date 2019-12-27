const getMaxLessThanK = require('./BitwiseOperators');
var fs = require('fs');

var numbers = [];
var lesses = [];
var expects = [];

var contents = fs.readFileSync('testInput.txt', 'utf8');

numbers = contents.split('\n');

var expects = fs.readFileSync('testOutput.txt', 'utf8');
expects = expects.split('\n');

for (var i = 0; i < numbers.length; i++) {
    let number = numbers[i].split(' ')[0];
    let less = numbers[i].split(' ')[1];
    let expectedResult = expects[i];
    test(`${number} numbers, less ${less}, expected ${expectedResult}`, () => {
        expect(getMaxLessThanK(number, less)).toBe(Number(expectedResult));
    });
}




/*test('995 numbers, less 236, expected 235', () => {
    expect(getMaxLessThanK(995, 236)).toBe(235);
});

test('132 numbers, less 107, expected 106', () => {
    expect(getMaxLessThanK(132, 107)).toBe(106);
});

test('178 numbers, less 104, expected 103', () => {
    expect(getMaxLessThanK(178, 104)).toBe(103);
});

test('394 numbers, less 378, expected 377', () => {
    expect(getMaxLessThanK(394, 378)).toBe(377);
});

test('773 numbers, less 29, expected 28', () => {
    expect(getMaxLessThanK(773, 29)).toBe(28);
});

test('159 numbers, less 117, expected 116', () => {
    expect(getMaxLessThanK(159, 117)).toBe(116);
});

test('928 numbers, less 443, expected 442', () => {
    expect(getMaxLessThanK(928, 443)).toBe(442);
});

test('250 numbers, less 146, expected 145', () => {
    expect(getMaxLessThanK(250, 146)).toBe(145);
});

test('730 numbers, less 468, expected 106', () => {
    expect(getMaxLessThanK(132, 107)).toBe(106);
});*/