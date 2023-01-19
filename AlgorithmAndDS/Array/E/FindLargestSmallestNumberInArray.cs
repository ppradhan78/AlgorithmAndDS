using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class LargestSmallestNumberInArray
    {
        public static void FindLargestSmallestNumberInArray()
        {
            int[] arr = { 1, -2, -71, -3, 4, 5 ,50,71,-1};
            int Max = 0, Min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }
            }
            Console.WriteLine("Largest,Smallest Number In Array : " + Max + "," + Min);
            Console.ReadKey();
        }
    }
}
