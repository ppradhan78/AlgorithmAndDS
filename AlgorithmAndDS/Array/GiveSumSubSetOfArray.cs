using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Array
{
    public static class GiveSumSubSetOfArray
    {
        public static void PrintSubSet()
        {
            int[] array = { 1, 4, 5, -1, 6, -4, -5, 13, 10 };
            int sum = 11;
            int[] outarray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        outarray[i] = array[i];
                        outarray[i + 1] = array[j];
                    }
                }
            }
            for (int i = 0; i < outarray.Length; i++)
            {
                Console.WriteLine("Hello Mono World" + outarray[i]);
            }
            Console.WriteLine("Hello Mono World" + outarray[0]);
        } 
    }
}
