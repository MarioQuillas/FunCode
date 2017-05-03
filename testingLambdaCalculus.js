//Church numerals
var c_0 = function(f) {
    return function(x) {
        return x;
    }
};

var c_1 = function(f) {
    return function(x) {
        return f(x);
    }
};

var c_2 = function(f) {
    return function(x) {
        return f(f(x));
    }
};

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

var test_true = IF(_true)(1)(2);
console.log(test_true);

var test_false = IF(_false)(1)(2);
console.log(test_false);

//Barendregt natural numbers
var zero = function(x) {
    return x;
}

var one = function(z) {
    return IF(z)(_false)(zero);
}

var two = function(z) {
    return IF(z)(_false)(one);
}