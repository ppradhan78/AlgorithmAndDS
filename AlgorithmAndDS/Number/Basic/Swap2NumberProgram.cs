using System;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/swap-two-numbers-without-using-temporary-variable/
    /// How to swap two numbers without using a temporary variable?
    /// </summary>
    public static class Swap2NumberProgram
    {
        public static void Swap2Number()
        {
            int x = 10;
            int y = 5;
            Console.WriteLine("Before swapping: x = " + x + ", y = " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping: x = " + x + ", y = " + y);
            Console.ReadKey();
            /*
            //############
            int x = 10;
            int y = 5;

            // Code to swap 'x' and 'y' 
            x = x * y; // x now becomes 50 
            y = x / y; // y becomes 10 
            x = x / y; // x becomes 5 

            Console.WriteLine("After swaping:"
                              + " x = " + x + ", y = " + y);

            //##############################

            int x = 10;
            int y = 5;

            // Code to swap 'x' (1010) 
            // and 'y' (0101) 

            // x now becomes 15 (1111) 
            x = x ^ y;

            // y becomes 10 (1010) 
            y = x ^ y;

            // x becomes 5 (0101) 
            x = x ^ y;

            Console.WriteLine("After swap: x = " + x + ", y = " + y);
            */
        }
    }

}
