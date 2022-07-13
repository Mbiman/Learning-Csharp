using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Prime
{
        public bool primeNumbers(int num)
        {       
            bool is_prime = true;

            for (int i = 2; i <= num/2; i++)
            {
                if (num == 0 || num == 1)
                {
                    is_prime = false;
                }
                if (num % i == 0)
                {
                    is_prime = false;
                    break;
                }      
            }
            return is_prime;
        }
}
