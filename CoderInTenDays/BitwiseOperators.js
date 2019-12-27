'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });

    main();
});

function readLine() {
    return inputString[currentLine++];
}
function getMaxLessThanK(border, less) {
    let maxResult = 0;
    for (let i = border; i > 0; i--) {
        for (let j = i - 1; j > 0; j--) {
            if ((j & i) < less && (j & i) > maxResult) {
                maxResult = (j & i);
            }
        }
    }
    return maxResult;
}

function main() {
    const q = +(readLine());

    for (let i = 0; i < q; i++) {
        const [n, k] = readLine().split(' ').map(Number);

        console.log(getMaxLessThanK(n, k));
    }
}

module.exports = getMaxLessThanK;