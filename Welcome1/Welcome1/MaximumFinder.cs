using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class MaximumFinder
{
        public static double Maximum( double x, double y, double z)
        {
            double maximumValue = x; //assuming x as the largest variable to start with

            //determine whether y > maximumValue
            if (y > maximumValue)
            {
                maximumValue = y;
            }

            //determine whether z > maximumValue
            if (z > maximumValue)
            {
                maximumValue = z;
            }

            return maximumValue;
        }
}
