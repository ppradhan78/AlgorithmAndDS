using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Traingle
{
    public static class GenerateTraingleByInputNumber
    {
        //
        public static void GenerateStarTraingle()
        {
            int i, j, rows;
            Console.Write("\n\n");
            rows = 5;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", "*");
                }
                Console.Write("\n");
            }
        }
        public static void GenerateTraingle()
        {
            int i, j, rows;
            Console.Write("\n\n");
            rows = 5;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", i);
                }
                Console.Write("\n");
            }
        }
        public static void GenerateTraingle1()
        {
            int i, j, k, l, n;
            Console.Write("Enter the Range=");
            n = 4;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
        }
    }
}
