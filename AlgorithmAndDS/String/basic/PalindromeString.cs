using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class PalindromeString
    {
        public static void IsPalindromeString()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Palindrome String             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Your String To Check :: ");

            string str = Convert.ToString(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = str.Length-1; i>=0; i--)
                {
                    sb.Append(str[i]);
                }
                if (str.Equals(sb.ToString(),StringComparison.OrdinalIgnoreCase))
                    Console.Write("Is a Palindrome String");
                else
                    Console.Write("Not a Palindrome String");
            }
        }
    }
}
