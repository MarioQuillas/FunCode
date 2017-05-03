var frontIF = function(condition) {
    return function(thenBranch) {
        return function(elseBranch) {
            return condition(thenBranch)(elseBranch)
        }
    }
}

var frontTrue = function(thenBranch){
    return function(elseBranch) {
        return thenBranch;
    }
};

var frontFalse = function(thenBranch) {
    return function(elseBranch) {
        return elseBranch;
    }
}

var test_true = frontIF(frontTrue)(1)(2);
console.log(test_true);

var test_false = frontIF(frontFalse)(1)(2);
console.log(test_false);