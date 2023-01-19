using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/c-program-find-largest-element-array/
    /// Detect if two integers have opposite signs
    /// </summary>
    public static class smallestElementArray
    {
        static int[] arr = { 10, 324, 45, 90, 9808 };
        static int largest()
        {
            // Initialize maximum element 
            int min = arr[0];
            // Traverse array elements from second and compare every element with current max  
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];

            return min;
        }


        // Driver Code 
        public static void FindSmallestElementArray()
        {
            Console.WriteLine("Smallest in given array { 10, 324, 45, 90, 9808 }is " + largest());
            Console.ReadKey();
        }
    }

}
