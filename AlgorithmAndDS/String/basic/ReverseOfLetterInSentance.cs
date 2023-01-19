using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class ReverseOfLetterInSentance
    {
        public static void ReverseOfALetterInSentance()
        {
            Console.WriteLine("Reverse Of Sentance");
            Console.WriteLine("_________________");
            Console.WriteLine("Enter a  Sentance");
            var x = Console.ReadLine();
            if (x != null && x.Length > 0)
            {
                string[] strings = x.Split(' ');
                StringBuilder sb = new StringBuilder();
                for (int i = strings.Length - 1; i >= 0; i--)
                {
                    char[] chars = strings[i].ToCharArray();
                    for (int j = chars.Length - 1; j >= 0; j--)
                    {
                        sb.Append(chars[j]);
                    }
                    sb.Append(" ");
                }
                Console.Write(sb.ToString());
            }
            Console.ReadKey();
        }
    }
}
