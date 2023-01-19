using System;

namespace AlgorithmAndDS.Array
{
    public static class LargestThreeElementOfArray
    {
        static void LargestThreeElement()
        {
            int[] arr = new int[] { 12, 13, 1, 10, 34, 1, 13 };
            int First = 0, Second = 0, Third = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > First)
                {
                    Third = Second;
                    Second = First;
                    First = arr[i];
                }
                else if (arr[i] > Second)
                {
                    Third = Second;
                    Second = First;
                }
                else if (arr[i] > Third)
                {
                    Third = Second;

                }
            }
            Console.WriteLine("Three largest elements are " + First + " " + Second + " " + Third);
        }


    }
}
