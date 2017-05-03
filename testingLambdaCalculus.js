// this is the crochet operator [M,N](boolean)
var IF = function(boolean) {
    return function(x) {
        return function(y) {
            return boolean(x)(y)
        }
    }
};

var _true = function(x){
    return function(y) {
        return x;
    }
};

var _false = function(x) {
    return function(y) {
        return y;
    }
};

var zero = function(x) {
    return x;
}

var one = function(z) {
    return IF(z)(_false)(zero);
}

var two = IF(_false)(one)

console.log(one(123));

var test_true = IF(_true)(1)(2);
console.log(test_true);

var test_false = IF(_false)(1)(2);
console.log(test_false);

