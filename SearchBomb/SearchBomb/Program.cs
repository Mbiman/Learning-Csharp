using System;


public class SearchBomb
{
    public static void Main(string[] args)
    {
       ParkingPrice garagePrice = new ParkingPrice();
       Console.Write("Enter Number of hours: ");
       int parkingHours = Convert.ToInt32(Console.ReadLine());
       Console.Write("Checking price for {0} hours.....", parkingHours);
       Console.WriteLine();
       Console.WriteLine();
       garagePrice.CarPark(parkingHours);
        Console.WriteLine();


        Atm atmCount = new Atm();
        Console.WriteLine("Enter your password: ");
        string pass = Console.ReadLine();
        atmCount.atmDigit(pass);
         Console.WriteLine();


        ArrayPositive myArray = new ArrayPositive();

        int[] arr = { 1, -3, 2, 4, 5, -6, 7, 13, -3, 43, 23 };
        
        int[] array = myArray.arrayCount(arr);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
         Console.WriteLine();



        Prime primeCheck = new Prime();
        
        
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());

        if (primeCheck.primeNumbers(num))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
         Console.WriteLine();

         
        Substring center = new Substring();

        Console.WriteLine("Enter text: ");
        string str = Console.ReadLine();

        center.middle(str);
       
        
    }
}
