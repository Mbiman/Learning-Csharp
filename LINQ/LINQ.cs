﻿// LINQ.cs
// LINQ to objects using an int array
using System;
using System.Linq;

class LINQ
{
    public static void Main( string[] args )
    {
        //create an integer array
        int[] values = {2, 9, 5, 0, 3, 7, 1, 4, 8, 5};

        //display original values
        Console.Write("Original array");
        foreach (var element in values)
            Console.Write(" {0}", element);

        // LINQ query that obtains values greater than 4 from the array
        var filtered =
            from value in values
            where value > 4
            select value;

        //display filtered results
        Console.Write("\nArray values greater than 4:");
        foreach (var element in filtered)
            Console.Write(" {0}", element);

        // use orderby clause to original values in ascending order
        var sorted = 
            from value in values
            orderby value
            select value;

        // display sorted results
        Console.Write("\nOriginal array, sorted:");
        foreach (var element in sorted)
            Console.Write(" {0}", element);

        //sort the filtered results into descending order
        var sortFilteredResults =
            from value in filtered
            orderby value descending
            select value;

        // display the sorted results
        Console.Write("\nValues greater than 4, descending order (separately):");
        foreach (var element in sortFilteredResults)
            Console.Write(" {0}", element);

        // filter original array and sort results in descending order
        var sortAndFilter =
            from value in values
            where value > 4
            orderby value descending
            select value;

        // display the filtered and sorted results
        Console.Write("\nValues greater than 4 in descending order (one query):");
        foreach (var element in sortAndFilter)
            Console.Write(" {0}", element);

        Console.WriteLine();
    } // end Main method
}// end Class LINQ