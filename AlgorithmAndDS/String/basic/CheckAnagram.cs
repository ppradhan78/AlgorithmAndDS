using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String.basic
{
    public static class CheckAnagram
    {
        public static void Anagram()
        {
            string str1 = "abcd";
            char[] chrs1 = str1.ToCharArray().OrderByDescending(c => c).ToArray(); ;
            string str2 = "acdb";
            char[] chrs2 = str2.ToCharArray().OrderByDescending(c => c).ToArray();
            bool isAnagram = false;
            if (chrs1.Length != chrs2.Length)
            {
                isAnagram = false;

            }
            isAnagram = checkarray(chrs1, chrs2);

            Console.WriteLine(isAnagram);

        }
        private static bool checkarray(char[] chrs1, char[] chrs2)
        {

            for (int i = 0; i < chrs1.Length; i++)
            {
                if (!chrs1[i].Equals(chrs2[i]))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
