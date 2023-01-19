using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public static class SubStringOfInput
    {
        public static void GenerateSubstring1()
        {
            string str = "ABCD";
            for (int i = 0; i < str.Length; i++)
            {
                string subStr = "";
                // Second loop is generating sub-String
                for (int j = i; j < str.Length; j++)
                {
                    subStr += str[j];
                    Console.Write(subStr + "\n");
                }
            }
        }
        
    }
}
