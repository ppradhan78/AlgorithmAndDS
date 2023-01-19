using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// Search an element in a sorted and rotated array
//https://www.geeksforgeeks.org/search-an-element-in-a-sorted-and-pivoted-array/

    /// </summary>
    public static class ArraySearch
    {
        static int search(int[] arr, int l, int h, int key)
        {
            if (l > h)
                return -1;

            int mid = (l + h) / 2;

            if (arr[mid] == key)
                return mid;

            /* If arr[l...mid] is sorted */
            if (arr[l] <= arr[mid])
            {
                /* As this subarray is sorted, we  
                can quickly check if key lies in  
                half or other half */
                if (key >= arr[l] && key <= arr[mid])
                    return search(arr, l, mid - 1, key);

                return search(arr, mid + 1, h, key);
            }

            /* If arr[l..mid] is not sorted,  
            then arr[mid... r] must be sorted*/
            if (key >= arr[mid] && key <= arr[h])
                return search(arr, mid + 1, h, key);

            return search(arr, l, mid - 1, key);
        }

        public static void Array_Search()
        {
            int[] arr = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            int key = Convert.ToInt32(Console.ReadLine());
            /*
             int n = arr.Length;
             Console.WriteLine("{ 4, 5, 6, 7, 8, 9, 1, 2, 3 } Enter the search element to find it's index:");
            
             int i = search(arr, 0, n - 1, key);

             if (i != -1)
                 Console.WriteLine("Index: " + i);
             else
                 Console.WriteLine("Key not found");
            */

            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    found = true;
                    Console.WriteLine("found: " + key + ", Index is :" + i);
                }
            }
            if (!found)
            {
                Console.WriteLine("note found: " + key);
            }

            Console.ReadKey();
        }
    }

}
