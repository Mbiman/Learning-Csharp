﻿
// LINQ to objects using a List<string>
using System;
using System.Linq;
using System.Collections.Generic;

public class LINQWithListCollection
{
    public static void Main(string[] args)
    {
        //populate a List of strings
        List<string> items = new List<string>();
        items.Add( "aQua" ); // add "aQua" to the end of the List
        items.Add( "RusT" ); // add "RusT" to the end of the List
        items.Add( "yElLow" ); // add "yElLow" to the end of the List
        items.Add( "rEd" ); // add "rEd" to the end of the List
        
        // convert all strings to uppercase; select those starting with "R"
        var startsWithR =
            from item in items
            let uppercaseString = item.ToUpper()
            where uppercaseString.StartsWith("R")
            orderby uppercaseString
            select uppercaseString;

        //display query results
        foreach (var item in startsWithR)
            Console.Write("{0} ", item);

        Console.WriteLine();

        items.Add( "rUbY" ); // add "rUbY" to the end of the List
        items.Add( "SaFfRon" ); // add "SaFfRon" to the end of the List

        //display updated query results
        foreach (var item in startsWithR)
            Console.Write("{0} ", item);

        Console.WriteLine();
    }//end Main Method
}
