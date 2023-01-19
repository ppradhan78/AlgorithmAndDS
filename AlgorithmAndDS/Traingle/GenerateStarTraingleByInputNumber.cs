using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Traingle
{
    public static class GenerateStarTraingleByInputNumber
    {
        public static void GenerateStarTraingle()
        {
            int n, j;
             n = 4;
            for (int i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
       
    }
}
