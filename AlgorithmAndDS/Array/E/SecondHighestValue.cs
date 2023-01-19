using System;

namespace AlgorithmAndDS.Array
{
    public static class SecondHighestValue
    {
        

        // Driver function
        public static void SecondHigestInArray()
        {
            int[] arr = { 12, 35, 1, 10, 34, 1 };
            int first = int.MinValue;
            int second = int.MinValue;
            Console.WriteLine(int.MinValue);
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second && arr[i] != first)
                    second = arr[i];
            }
            if (second == int.MinValue)
                Console.Write("There is no second largest"
                              + " element\n");
            else
                Console.Write("The second largest element"
                              + " is " + second);
        }
    }
}
