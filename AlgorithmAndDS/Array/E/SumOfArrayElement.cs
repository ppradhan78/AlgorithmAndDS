using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class SumOfArrayElement
    {
        // Driver Code 
        public static void SumOfArray()
        {
              int[] arr = { 1, 2, 3, 4, 5 };
            int Sum = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
                Sum = Sum + arr[i];
            }
            Console.WriteLine("Sum of given array { 1,2,3,4,5 }is " + Sum);
            Console.ReadKey();
        }
    }
}
