using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/smallest-of-three-integers-without-comparison-operators/?ref=lbp
    /// Smallest of three +ve integers without comparison operators
    /// </summary>
    public static class SmallestPosNoWithoutCompareProgram
    {
        static int smallest(int x, int y, int z)
        {
            int c = 0;
            while (x != 0 && y != 0 && z != 0)
            {
                x--;
                y--;
                z--;
                c++;
            }
            return c;
        }

        // Driver Code 
        public static void SmallestPosNoWithoutCompare()
        {
            int x = 3, y = 2, z = 4;

            Console.Write("Minimum of 3" + " numbers is " + smallest(x, y, z));

            Console.ReadKey();
        }
    }

}
