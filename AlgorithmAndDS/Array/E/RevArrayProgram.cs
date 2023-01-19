using System;
using System.Linq;

namespace AlgorithmAndDS
{
    /// <summary>
    /// reverse an array or string
    /// </summary>
    class RevArrayProgram
    {
        static void rvereseArray(int[] arr)
        {
            int temp;
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
        static int[] createArray(int arryLength)
        {
            int[] arr = new int[arryLength];

            for (int i = 0; i < arryLength; i++)
            {
                Console.WriteLine("Enter the element  of array");
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }
      
        public static void RevOfArray()
        {

            //Console.WriteLine("Enter the lengt of array");
            //int arryLength = Convert.ToInt32(Console.ReadLine());
            //int[] arr = createArray(arryLength);

            int[] arr = { 1, 2, 3, 4, 5, 6 };


            printArray(arr);
            rvereseArray(arr);
            Console.Write("Reversed array is \n");
            printArray(arr);
            Console.ReadKey();


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //for (int i = arr.Length-1; i>0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in arr.Reverse())
            //{
            //    Console.WriteLine(item);
            //}
        }
        public static void ReverseOfArrayForLoop()
        {
            Console.WriteLine("###################");
            int[] arry = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arry.Length; i++)
            {
             Console.WriteLine(arry[i]);
            }
            Console.WriteLine("-----------");
            for (int i = arry.Length - 1; i >=0; i--)
            {
                Console.WriteLine(arry[i]);
            }
        }
        public static void ReverseOfArrayForeachLoop()
        {
            Console.WriteLine("###################");
            int[] arry = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in arry)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            foreach (var item in arry.Reverse())
            {
                Console.WriteLine(item);
            }
        }
    }

}
