var factorial = function(n) {
	// base case: 
	if(n <= 1){
	    return 1;
	}
	// recursive case:
	return factorial(n - 1) * n;
}; 

println("The value of 0! is " + factorial(0) + ".");
println("The value of 5! is " + factorial(5) + ".");
println("The value of 6! is " + factorial(6) + ".");
println("The value of 3! is " + factorial(3) + ".");

Program.assertEqual(factorial(0), 1);
Program.assertEqual(factorial(5), 120);
Program.assertEqual(factorial(6), 720);
Program.assertEqual(factorial(3), 6);
