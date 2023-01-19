using System;

namespace AlgorithmAndDS.Array
{
    public static class DuplicateElementInArray
    {

        public static void DuplicateElement()
        {
            int[] arr = { 6, 10, 5, 4, 9, 120, 4, 6, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
        }
        public static void DistanctElement()
        {
        int[] arr = { 6, 10, 5, 4, 9, 120, 4, 6, 10 };
            // Pick all elements one by one
        for (int i = 0; i<arr.Length; i++)
        {
             
            // Check if the picked element
            // is already printed
            int j;
            for (j = 0; j<i; j++)
                if (arr[i] == arr[j])
                     break;
     
            // If not printed earlier,
            // then print it
            if (i == j)
            Console.Write(arr[i] + " ");
        }
}
    }
}
