using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Number
{
    public static class SearchElementToEnd
    {
        public static void moveElementToEnd()
        {
            /* int[] array = { 2, 3, 8, 2, 9 };
             int toMove = 8;
             int[] outputarray = new int[array.Length];
             int j = array.Length - 1;
             for (int i = 0; i <= array.Length - 1; i++)
             {

                 if (array[i] == toMove)
                 {
                     outputarray[j] = array[i];
                     j--;
                 }
                 else
                 {
                     outputarray[j] = array[i];
                 }

             }
             for (int a = 0; a < outputarray.Length; a++)
             {
                 Console.WriteLine(outputarray[a] + "\n");
             }*/

            int[] array = { 2, 3, 8, 2, 9 };
            int toMove = 2;
            // Mark left pointer
            int i = 0;

            // Mark the right pointer
            int j = array.Length - 1;

            // Iterate until left pointer
            // crosses the right pointer
            while (i < j)
            {
                while (i < j && array[j] == toMove)

                    // Decrement right pointer
                    j--;

                if (array[i] == toMove)

                    // Swap the two elements
                    // in the array
                    swap(array, i, j);

                // Increment left pointer
                i++;
            }

            // Return the result
            for (int a = 0; a < array.Length; a++)
            {
                Console.WriteLine(array[a]);
            }
        }

        static int[] swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }

    }
}
