using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    /// <summary>
    /// Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
    //https://www.geeksforgeeks.org/array-rotation/
    /// </summary>
    class ArrayNRotateProgram
    {
        static void leftRotate(int[] arr, int PosttionOfRotate, int LengthOfArray)
        {
            for (int i = 0; i < PosttionOfRotate; i++)
                leftRotatebyOne(arr, LengthOfArray);
        }

        static void leftRotatebyOne(int[] arr, int LengthOfArray)
        {
            int i, temp = arr[0];
            for (i = 0; i < LengthOfArray - 1; i++)
                arr[i] = arr[i + 1];

            arr[i] = temp;
        }

        /* utility function to print an array */
        static void printArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        // Driver code 
        public static void ArrayNRotate()
        {
            Console.WriteLine("Array:{ 1, 2, 3, 4, 5, 6, 7,18 }");
            Console.WriteLine("Enter d:");

            int PosttionOfRotate = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5, 6, 7,18 };
            leftRotate(arr, PosttionOfRotate, arr.Length);
            printArray(arr, arr.Length);
            Console.ReadKey();
        }
        public void RotateArrayByInputNumber()
        {
            int[] intArray = { 1, 2, 3, 4 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("Enter the position");
            List<int> outputlist = new List<int>();
            int PosttionOfRotate = Convert.ToInt32(Console.ReadLine());
            for (int i = PosttionOfRotate; i < intArray.Length; i++)
            {
                outputlist.Add(intArray[i]);
            }
            for (int i = 0; i < PosttionOfRotate; i++)
            {
                outputlist.Add(intArray[i]);
            }
            Console.WriteLine(Environment.NewLine);
            foreach (var item in outputlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
