
//Generic List<T> collection demonstration
using System;
using System.Collections.Generic;

public class ListCollection
{
    public static void Main(string[] args)
    {
        //create a new list of strings
        List<string> items = new List<string>();

        items.Add("red"); // append an item to the list
        items.Insert(0, "yellow"); // insert the value at the index 0

        //display the colors in the list
        Console.Write("Display list contents with counter-controlled loop:");
        for (int i = 0; i < items.Count; i++)
            Console.Write(" {0}", items[i]);

        //display colors using foreach
        Console.Write("\nDisplay list contents with foreach statement");
        foreach (var item in items)
            Console.Write(" {0}", item);

        items.Add("green"); //add "green" to the end of the list
        items.Add("yellow"); //add "yellow" to the end of the list
        items.Add("blue"); // add "blue" to the end of the list

        //display the list
        Console.Write("\nList with three new elements:");
        foreach (var item in items)
            Console.Write(" {0}", item);

        items.Remove("yellow"); //remove the first "yellow"

        //display the list
        Console.Write("\nRemove first instance of yellow:");
        foreach (var item in items)
            Console.Write(" {0}", item);

        items.RemoveAt(1); //remove item at index 1

        //display the list
        Console.Write("\nRemove second list element (green):");
        foreach (var item in items)
            Console.Write(" {0}", item);

        //check if a particular value is in the list
        Console.WriteLine("\n'red' is {0} in the list", items.Contains("red")? string.Empty: "not");

        //display number of elements in the list
        Console.WriteLine("Count: {0}", items.Count);

        //display the capacity of the List
        Console.WriteLine("Capacity: {0}", items.Capacity);
    }// end Main
}