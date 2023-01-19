using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Sorting.Selection
{
    public static class SelectionSortExample
    {
        public static void sort()
        {
            int[] arr = { -64, 25, 12, 22, 11 ,0,1};
            int n = arr.Length;
            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_element = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_element])
                    {
                        min_element = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[min_element];
                arr[min_element] = arr[i];
                arr[i] = temp;
            }
            Helper.printArray(arr);
        }
        public static void sort1()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                //int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[i] < arr[j])
                    {
                        // min_idx = j;

                        // Swap the found minimum element with the first
                        // element
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        j = -1;
                    }

            }
            Helper.printArray(arr);
        }
    }
}
