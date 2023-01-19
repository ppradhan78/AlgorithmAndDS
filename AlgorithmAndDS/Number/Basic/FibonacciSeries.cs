using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    /// Fibonacci numbers
    /// </summary>
    public static class FibonacciSeries
    {
       
        private static void GenerateFibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3;
            int number = 5;
            Console.Write(n1 + " " + n2 + " "); 
            for (int i = 2; i < number; ++i) 
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        // Driver Code 
        public static void  GetFibonacciNumber()
        {
            GenerateFibonacciSeries();

            Console.ReadKey();
        }
    }

}
