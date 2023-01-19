using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array
{
    public static class RemoveEvenIntegersInAarray
    {
        private static int[] RemoveEvenIntegers()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    arr[m] = arr[i];
                    m++;
                }

            }
            int[] temp = new int[m];
            for (int i = 0; i < m; i++)
                temp[i] = arr[i];

            arr = temp;
            return arr;
            
        }
        public static void PrintRemoveEvenIntegers()
        {
            Console.WriteLine("{ 1, 2, 3, 4, 5 }");
            for (int i = 0; i < RemoveEvenIntegers().Length; i++)
            {
                Console.WriteLine(RemoveEvenIntegers()[i]);
            }
            Console.ReadKey();
        }
    }
}
