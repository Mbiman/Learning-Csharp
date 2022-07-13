using System;
using System.Text.RegularExpressions;

class Atm
{
    public void atmDigit(string password)
    {
        int length = password.Length;

        if (Regex.Match(password, @"^[0-9]+$").Success)
        {
            if (length == 4 || length == 6)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            } 
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

