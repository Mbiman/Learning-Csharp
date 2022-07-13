using System;

public class Months
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetMonth());
    }
    static string GetMonth()
    {
        string monthName;
        int monthNum;

        Console.WriteLine("Enter a Month: ");
        monthNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        

        switch (monthNum)
        {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                monthName = "Invalid month number";
                break;
        }
      

        Console.WriteLine("The month is: ");
        return monthName;
    }
}