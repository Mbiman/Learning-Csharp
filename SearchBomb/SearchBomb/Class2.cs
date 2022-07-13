using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Class2
{
    public string Checker()
    {
        Console.WriteLine("Enter a sentence");
        String TheSentence = Console.ReadLine();
        

        if (TheSentence.Contains("bomb") == true)
        {
            Console.WriteLine("Duck!!!");
        }
        else
        {
            Console.WriteLine("There is no bomb, relax");
        }

        return TheSentence;
    }
}