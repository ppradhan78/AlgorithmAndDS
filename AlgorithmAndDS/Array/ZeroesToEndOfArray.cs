using System;

namespace AlgorithmAndDS.Array
{
    public static class ZeroesToEndOfArray
    {
        static void pushZerosToEnd(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    // here count is incremented
                    arr[count++] = arr[i];
                }
            }
            while (count < n)
                arr[count++] = 0;
        }

        // Driver function
        public static void Print()
        {
            int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
            pushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
