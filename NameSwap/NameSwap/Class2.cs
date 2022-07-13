using System;


internal class Class2
{
    public static string SearchBomb()
    {
        Console.WriteLine("Enter a sentence");
        String Sentence = Console.ReadLine();
        Console.WriteLine();

        string[] allSentence = Sentence.Split(" ");

        foreach (string s in allSentence)
        {
            Console.WriteLine(s);
        }
    } 
}