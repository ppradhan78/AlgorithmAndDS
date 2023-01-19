using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Number
{
    public static class SqrtOfNumber
    {
        static int floorSqrt(int x)
        {
            // Base cases
            if (x == 0 || x == 1)
                return x;

            // Starting from 1, try all
            // numbers until i*i is
            // greater than or equal to x.
            int i = 1, result = 1;

            while (result <= x)
            {
                i++;
                result = i * i;
            }
            return i - 1;
        }

        public static void FindSqrt()
        {
            int x = 11;
            floorSqrt(x);
            Console.WriteLine(floorSqrt(x));
        }
    }
}
