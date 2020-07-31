/**
 * Ex 1
 */
var arr = [1, 2, 'hello', NaN, {
        city: 'IasI',
        zip: null
    },
    [11, 12], undefined, undefined, undefined
]

var arrResult = {};

function getStats(arr) {
    for (let index = 0; index < arr.length; ++index) {
        if (Array.isArray(arr[index])) {
            arrResult.Array = arrResult.Array + 1 || 1;
        } else if (Number.isNaN(arr[index])) {
            arrResult.NaN = arrResult.NaN + 1 || 1;
        } else {
            let string = arr[index] === 'object' ? auto instanceof arr[index] : typeof(arr[index]);
            arrResult[string] = arrResult[string] + 1 || 1;
        }
    }
}

function objectIterate(object) {
    for (const property in object) {
        console.log(`${property}: ${object[property]}`);
    }
}

getStats(arr);
objectIterate(arrResult);

/**
 * Ex 2
 */
function addF(f) {
    function addG(g) {
        return f + g;
    }
    return addG;
}

let add = addF(13);

console.log(add(10));
console.log(add(-5));

/**
 * Ex 3
 */

function(fn, max) {
    return function(param) {
        return fn(max, param);
    }
}

/** 
 * 5
 */
var inputString = "Ana are mere si mai are ceva" //7
var resultMap = new Map();

function splitString(stringInput) {
    return stringInput.split(" ");
}

function wordCount(inputString) {
    let newString = splitString(inputString);

    for (let index = 0; index < newString.length; ++index) {
        resultMap[newString[index]] =
            resultMap[newString[index]] + 1 || 1;
    }

    return resultMap;
}

console.log(wordCount(inputString));

/**
 * 6
 */
Array.prototype.transform = function ArrayTransform(newArray, callBack) {
    newArray = [];

    for (let index = 0; index < this, this.length; ++i) {
        newArray.push(callBack(this[index], index, this))
    }

    return newArray;
}

/**
 * 7
 */
Array.prototype.keep = function ArrayKeep(newArray, callBack) {
    newArray = [];

    for (let index = 0; index < this.length; ++i) {
        if (callBack(this[index], index, this))
            newArray.push(callBack(this[index]));
    }

    return newArray;
}