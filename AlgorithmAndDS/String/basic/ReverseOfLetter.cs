using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class ReverseOfLetter
    {
        public static void ReverseOfALetter()
        {
            Console.WriteLine("Reverse Of Word");
            Console.WriteLine("_________________");
            Console.WriteLine("Enter a  Word");
            var x = Console.ReadLine();
            if (x != null && x.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                char[] strings = x.ToCharArray();
                for (int i = strings.Length - 1; i >= 0; i--)
                {
                    sb.Append(strings[i]);
                }
                Console.Write(sb.ToString());
            }
            Console.ReadKey();
        }
        public static void ReverseOfALetter1()
        {
            string str = "Prasanta";
            char[] chr = str.ToCharArray();
            int len = chr.Length;
            int j = len - 1;
            while (j >= 0)
            {
                Console.WriteLine(chr[j]);
                j--;
            }
            Console.ReadKey();

        }
    }
}
