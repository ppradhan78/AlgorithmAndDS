using System;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmAndDS
{
    /// <summary>
    /// product of array
    /// Input  : ar[] = {1, 2, 3, 4, 5}
    //Output : 120
    //Product of array elements is 1 x 2
    //x 3 x 4 x 5 = 120.
    /// https://www.geeksforgeeks.org/program-for-product-of-array/?ref=rp
    /// </summary>
    class ProdArrayProgram
    {
        public static void ProdOfArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product = product * arr[i];
            }
            Console.WriteLine("product of array element:" + product);
            Console.ReadKey();
        }
    }

}
