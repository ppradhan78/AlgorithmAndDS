using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class CountingFrequenciesArray
    {
        public static void countFreq()
        {
            int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
            int n = arr.Length;
            bool[] visited = new bool[n];

            // Traverse through array elements and
            // count frequencies
            for (int i = 0; i < n; i++)
            {
                // Skip this element if already processed
                if (visited[i] == true)
                    continue;
                // Count frequency
                int count = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                Console.WriteLine(arr[i] + " " + count +"\n");
            }
        }

        // Driver code
       
    }
}
