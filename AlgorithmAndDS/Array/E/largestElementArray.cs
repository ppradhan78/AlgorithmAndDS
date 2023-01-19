using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/c-program-find-largest-element-array/
    /// Detect if two integers have opposite signs
    /// </summary>
    public static class LargestElementArray
    {
        static int[] arr = { 10, 324, 45, 90, 9808 };
        static int largest()
        {
            // Initialize maximum element 
            int max = arr[0];
            // Traverse array elements from second and compare every element with current max  
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }


        // Driver Code 
        public static void FindLargestElementArray()
        {
            Console.WriteLine("Largest in given array { 10, 324, 45, 90, 9808 }is " + largest());
            Console.ReadKey();
        }
    }

}
