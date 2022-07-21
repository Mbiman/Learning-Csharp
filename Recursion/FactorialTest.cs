
// Recursive factorial method
using System;

public class FactorialTest
{
    public static void Main(string[] args)
    {
        // calculate the factorials of 0 through 20
        for (long i = 0; i <= 20; ++i)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        }
    }// end main
    // recursive declaration of method factorial
    public static long Factorial(long number)
    {
        //base case
        if (number <= 1)
            return 1;
            // recursion step
        else
            return number * Factorial(number - 1);
    } //end method Factorial
} // end class FactorialTest