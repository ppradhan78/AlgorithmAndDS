using System;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/program-to-print-product-of-even-and-odd-indexed-elements-in-an-array/?ref=rp
    /// print product of even and odd indexed elements in an Array
    /// Program to print product of even and odd indexed elements in an Array
    /// Input : arr = {1, 2, 3, 4, 5, 6} Output : Even Index Product : 15     Odd Index Product : 48
    /// </summary>
    public static class ArrayEvenOddNumber 
    {
        public static void Array_ProductOfEvenOddNumberIndex()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int even = 1;
            int odd = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even *= arr[i];
                }
                else
                {
                    odd *= arr[i];
                }
            }
            Console.WriteLine("Even Index Product : " + even);
            Console.WriteLine("Odd Index Product : " + odd);
            Console.ReadKey();
        }
    }

}
