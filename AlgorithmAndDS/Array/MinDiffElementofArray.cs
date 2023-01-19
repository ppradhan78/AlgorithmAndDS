using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// Find the minimum element in a sorted and rotated array
//https://www.geeksforgeeks.org/find-minimum-element-in-a-sorted-and-rotated-array/
    /// </summary>
    public static class MinDiffElementofArray
    {
        static int findMinDiff(int[] arr, int n)
        {

            // Initialize difference as infinite
            int diff = int.MinValue;

            // Find the min diff by comparing difference
            // of all possible pairs in given array
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (Math.Abs((arr[i] - arr[j])) < diff)
                        diff = Math.Abs((arr[i] - arr[j]));

            // Return min diff
            return diff;
        }

        public static void MinDiff()
        {
            int[] arr = new int[] { 1, 5, 3, 19, 18, 25 };
            Console.Write("Minimum difference is " +
                            findMinDiff(arr, arr.Length));
        }
    }

}
