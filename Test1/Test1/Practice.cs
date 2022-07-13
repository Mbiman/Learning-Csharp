using System;

internal class Practice
{
    public int luckyArrays()
    {
        int[] luckyNumbers = { 3, 2, 45, 7, 67, 9, 42 };

        for (int i = 0; i < luckyNumbers.Length; i++)
        {
            Console.WriteLine(luckyNumbers[i]);
        }

        return 0;
    }

    public double GetPower()
    {
        Console.WriteLine("Please enter only DIGITS");
        Console.WriteLine();
        Console.Write("Enter Base Number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Power Number: ");
        double powNum = Convert.ToDouble(Console.ReadLine());

        double result = 1;

        for (int i = 0; i < powNum; i++)
        {
            result = result * baseNum;
        }

        Console.WriteLine(result);

        return result;


    }

    public int TwoDArray()
    {
        int[,] numberGrid =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        for (int i = 0; i < numberGrid.GetLength(0); i++)
        {
            for (int j = 0; j < numberGrid.GetLength(1); j++)
            {
                Console.WriteLine(numberGrid[i, j]);
            }
        }


        return 0;
    }

    public void Exception()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32((Console.ReadLine()));

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine(num1 / num2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }

}

