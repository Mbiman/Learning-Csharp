using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class ArrayPositive
{
    public int[] arrayCount(int[] array)
    {
        List<int> finalArray = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            int count = array.Count(n => n >= 0);
            finalArray.Add(count);
            
            var negative = array.Where(n => n < 0);

            var sum = negative.Sum();
            finalArray.Add(sum);

            break;
        }
        int[] result = finalArray.ToArray();

        return result;
    }
}

