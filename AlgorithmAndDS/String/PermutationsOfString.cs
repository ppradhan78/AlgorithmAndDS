using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class StringPermutations
    {
        private static void permute(string inputString, string outputString)
        {
            if (inputString.Length == 0)
            {
                Console.WriteLine(outputString);
                return;
            }
            for (int i = 0; i < inputString.Length; i++)
            {
                char ch = inputString[i];
                string left_substr = inputString.Substring(0, i);
                string right_substr = inputString.Substring(i + 1);
                string rest = left_substr + right_substr;
                permute(rest, outputString + ch);
            }
        }
        public static void PermutationsOfString()
        {
            string answer = string.Empty;
            Console.WriteLine("Enter a string:");
            string str = Convert.ToString(Console.ReadLine());
            int n = str.Length;
            Console.WriteLine("========================");
            permute(str, answer);
        }
    }
}
