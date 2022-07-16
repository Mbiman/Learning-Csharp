
//optional argument demonstration with method power
using System;

class calculatePowers
{
    // call power with and without optional arguments
    public static void Main(string[] args)
    {
        Console.WriteLine( "Power(10) = {0}", Power( 10 ) ) ;
        Console.WriteLine( "Power(2, 10) = {0}", Power( 2, 10 ) );
    }

    //use iteration to calculate power
    public static int Power(int baseValue, int exponentValue = 2)
    {
        int result = 1; //initialize total

        for (int i = 1; i <= exponentValue; i++)
            result *= baseValue;
            return result;
    }
}