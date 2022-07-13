using System;
using System.Linq;
using System.Collections.Generic;

internal class Array
  {
    public int[] LargestArray(int[][] array)
    {
        int max = 0;
        List<int> maxArray = new List<int>();
        
        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            { 
                if (array[i][j] > max)
                {
                    max = array[i][j];
                }
                
            }
            maxArray.Add(max);
           
            //Console.WriteLine(max);
            max = 0;
            
        }

        int[] maximum = maxArray.ToArray();

        //Console.WriteLine(maximum);
        return maximum;
    }
  }

