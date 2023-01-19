using System;

namespace AlgorithmAndDS.Array
{
    public static class BinarySearchExample
    {
        static int Search(int[] arr, int low, int high, int searchelement)
        {

            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // If the element is present at the
                // middle itself
                if (arr[mid] == searchelement)
                    return mid;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (arr[mid] > searchelement)
                    return Search(arr, low, mid - 1, searchelement);

                // Else the element can only be present in right subarray
                return Search(arr, mid + 1, high, searchelement);
            }

            // We reach here when element is not present in array
            return -1;
        }
        public static void BinarySearch()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 100;

            int result = Search(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }
    }
}
