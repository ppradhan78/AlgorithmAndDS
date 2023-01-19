using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/program-for-nth-fibonacci-number/
    /// Fibonacci numbers
    /// </summary>
    public static class FibonacciNumber
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
            }
        }
       
        // Driver Code 
        public static void  GetFibonacciNumber()
        {
            Console.WriteLine("Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write(GetFibonacciNumber(n));

            Console.ReadKey();
        }
    }

}
