//Rolling a Six-Sided Die
using System;

public class RandomIntegers
{
    public static void Main(string[] args)
    {
        Random randomNumbers = new Random(); //random-number generator
        int face; //stores each random integer generated

        //loop 20x
        for (int i = 1; i <= 20; i++)
        {
            //pick random integer from 1 to 5
            face = randomNumbers.Next(1, 6);

            Console.Write("{0} ", face); //display generated value

            //if i is divisible by 5, start a new line of output
            if (i % 5 == 0)
            {
                Console.WriteLine();
            }
        }// end for loop
    }//end Main method
}// end class RandomIntegers