//using System;

//namespace AlgorithmAndDS
//{
//    /// <summary>
//    /// Mean of array 
//    /// https://www.geeksforgeeks.org/program-for-mean-and-median-of-an-unsorted-array/
//    /// </summary>
//   public static  class MeanMedianArrayProgram
//    {
//        private static double findMean(int[] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum += arr[i];
//            }
//            return (double)sum / (double)arr.Length;
//        }
//        private static double findMedian(int[] arr)
//        {
//            // First we sort  the array 
//            Array.Sort(arr);

//            // check for even case 
//            if (arr.Length % 2 != 0)
//                return (double)arr[arr.Length / 2];

//            return (double)(arr[(arr.Length - 1) / 2] +
//                            arr[arr.Length / 2]) / 2.0;
//        }
//        public static void FindMeanMedianArrayProgram()
//        {
//            int[] arr = { 1, 3, 4, 2, 6, 5, 8, 7 };


//            Console.WriteLine("Mean :" + findMean(arr));
//            Console.WriteLine("Median :" + findMedian(arr));
//            Console.ReadKey();
//        }
//    }

//}
