using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Substring
{
        public void middle(string str)
        {
            // Finding string length
            int length = str.Length;
 
            if (length % 2 == 0)
            {
                int middle = (length / 2);
                Console.Write(str[middle - 1]);
                Console.WriteLine(str[middle]);
            }
            else
            {
                int middle = length / 2;
                Console.WriteLine(str[middle]);
            }         
        }
}