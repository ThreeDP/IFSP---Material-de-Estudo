var isEven = function(n) {
    return n % 2 === 0;
};

var isOdd = function(n) {
    return !isEven(n);
};

var power = function(x, n) {
    println("Computing " + x + " raised to power " + n + ".");
    // base case
    if(n === 0) {
        return 1;
    }
    
    
    // recursive case: n is negative
    if(n < 0) {
        return 1 / power(x, - n);
    }
    
    
    // recursive case: n is odd
    if(isOdd(n) === true) {
        return power(x, n - 1) * x;
    }
    
    
    // recursive case: n is even
    if(isEven(n) === true) {
        var p = power(x, n/ 2);
        return p * p;
    }
    
    
};

var displayPower = function(x, n) {
    println(x + " to the " + n + " is " + power(x, n));
};

displayPower(3, 0);
Program.assertEqual(power(3, 0), 1);
displayPower(3, 1);
Program.assertEqual(power(3, 1), 3);
displayPower(3, 2);
Program.assertEqual(power(3, 2), 9);
displayPower(3, -1);
Program.assertEqual(power(3, -1), 1/3);
displayPower(8, 2);
Program.assertEqual(power(8, 2), 64);
displayPower(2, 5);
Program.assertEqual(power(2, 5), 32);
