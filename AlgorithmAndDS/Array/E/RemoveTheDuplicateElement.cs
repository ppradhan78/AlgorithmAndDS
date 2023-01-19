using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class RemoveTheDuplicateElement
    {
        public static void RemoveTheDuplicateElementArray()
        {
            //Console.WriteLine("{ 1, -2, -71, -3, 4,4, 5, 50, 71, 1,2 }");
            Console.WriteLine("{ 1,2,3,4,6,7,5 }");
            int[] arr = { 1, 2, 3, 4, 1, 1, 7, 3, 6, 7, 5 };
            List<int> array = new List<int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    array.Add(arr[i]);
                }
            }
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
