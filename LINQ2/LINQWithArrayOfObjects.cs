﻿
// LINQ to objects using an array of Employee objects.
using System;
using System.Linq;

public class LINQWithArrayOfObjects
{
    public static void Main(string[] args)
    {
        //initialize array of employees
        Employee[] employees = 
        {
            new Employee("Jason", "Red", 5000M),
            new Employee( "Ashley", "Green", 7600M ),
            new Employee( "Matthew", "Indigo", 3587.5M ),
            new Employee( "James", "Indigo", 4700.77M ),
            new Employee( "Luke", "Indigo", 6200M ),
            new Employee( "Jason", "Blue", 3200M ),
            new Employee( "Wendy", "Brown", 4236.4M )
        };// end init list

        //display all employees
        Console.WriteLine("Original array:");
        foreach (var element in employees)
            Console.WriteLine(element);

        //filter a range of salaries using && in a LINQ query
        var between4k6k = 
            from e in employees
            where e.MonthlySalary >= 4000M && e.MonthlySalary <= 6000M
            select e;

        //display employees making between 4k and 6k per month
        Console.WriteLine(string.Format("\nEmployees earning in the range {0:C}--{1:C} per month:", 4000, 6000));
        foreach (var element in between4k6k)
            Console.WriteLine(" {0}", element);

        //order the employees by lastname, then first name with LINQ
        var nameSorted =
            from e in employees
            orderby e.LastName, e.FirstName
            select e;

        //header
        Console.WriteLine("\nFirst employee when sorted by name:");

        //attempt to display the first result of the above LINQ query
        if (nameSorted.Any())
            Console.WriteLine(nameSorted.First());
        else
            Console.WriteLine("not found");

        // use LINQ to select employee last names
        var lastNames =
            from e in employees
            select e.LastName;

        //use method Distinct to select unique last names
        Console.WriteLine("\nUnique employee last names:");
        foreach (var element in lastNames.Distinct())
            Console.WriteLine(element);

        //use LINQ to select first and last names
        var names =
            from e in employees
            select new{e.FirstName, last = e.LastName};

        //display full names
        Console.WriteLine("\nNames only:");
        foreach (var element in names)
            Console.WriteLine(element);

        Console.WriteLine();
    } //end Main method
}