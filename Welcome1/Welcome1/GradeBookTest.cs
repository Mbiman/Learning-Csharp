// Fig. 4.5: GradeBookTest.cs
// Create a GradeBook object and pass a string to
// its DisplayMessage method.
using System;

public class GradeBookTest
{

    public static void Main(string[] args)
    {
        //GradeBook gradeBook1 = new GradeBook("CSC101 Introduction to C# Programming");
        //GradeBook gradeBook2 = new GradeBook("CSC102 Data structures in C#");

        //Console.WriteLine("gradeBook1 coursename is: {0}", gradeBook1.CourseName);
        //Console.WriteLine("gradeBook2 coursename is: {0}", gradeBook2.CourseName);
        //Console.WriteLine();

        //Console.Write("Enter your first new course name: ");
        //gradeBook1.CourseName = Console.ReadLine();

        //Console.Write("Enter your second new course name: ");
        //gradeBook2.CourseName = Console.ReadLine();
        //Console.WriteLine();

        //Console.WriteLine("gradeBook1 coursename is: {0}", gradeBook1.CourseName);
        //Console.WriteLine("gradeBook2 coursename is: {0}", gradeBook2.CourseName);

        Account account1 = new Account(50.00M);
        Account account2 = new Account(-7.53M);

        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);
        Console.WriteLine();

        decimal depositAmount; //deposit amount read from user

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account1: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount);
        account1.Credit(depositAmount);
        
        //display account balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);
        Console.WriteLine();

        // prompt and obtain user input
        Console.Write("Enter deposit amount for account2: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount);
        account2.Credit(depositAmount);
       

        //display account balances
        Console.WriteLine("account1 balance: {0:C}", account1.Balance);
        Console.WriteLine("account2 balance: {0:C}", account2.Balance);

    }
}