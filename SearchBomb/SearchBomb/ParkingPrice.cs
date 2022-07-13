using System;


internal class ParkingPrice
{

    public double CarPark(int hours)
    {
        int oneDay = 24;
        int fiveHours = 5;
        double price;
        int multiple = hours / oneDay;
        int diff = hours % oneDay;

        if (hours >= oneDay)
        {
           price = ((15 * multiple) + (diff * 0.5));
        }
        else if (hours > fiveHours && hours < oneDay)
        {
             price = fiveHours + ((hours - fiveHours) * 0.5);
        }
        else
        {
             price = hours * 1;
        }
        Console.WriteLine("The price is {0:C}", price);
        return 0;      
        }
}
