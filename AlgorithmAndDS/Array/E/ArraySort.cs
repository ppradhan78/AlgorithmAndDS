using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class ArraySort
    {
        public static void Sort1()
        {
            Console.WriteLine("Array sort in asscending order :{ 2, 9, 4, 3, 5, 1, 7 }");
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    int temp = intArray[i];
                    intArray[i] = intArray[i + 1];
                    intArray[i + 1] = temp;
                    i = -1;
                }

            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static void Sort()
        {
            Console.WriteLine("Array sort in asscending order :{ 2, 9, 4, 3, 5, 1, 7 }");
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static void SortDesc()
        {
            Console.WriteLine("Array sort in descending order :{ 2, 9, 4, 3, 5, 1, 7 }");
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
