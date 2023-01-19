using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class MergeTwoArray
    {
        public static void Merge()
        {
            int[] arr1 = {1,2,3,4 };
            int[] arr2= { 4,5,6 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            int j = 0;
            for (int i = arr1.Length; i < arr3.Length; i++)
            {
                arr3[i] = arr2[j];
                j++;
            }
            Console.WriteLine("{1,2,3,4 } { 4,5,6 }");
            Console.WriteLine("======================");
            for (int i = 0; i < arr3.Length ; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}
