using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String.basic
{
    public static class StringHasVowels
    {

        public static void ContainsVowel()
        {
            char[] vowels = new[] { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            bool isexist = false;
            string word = "cd";
            foreach (char vowel in vowels)
            {
                if (word.Contains(vowel))
                {
                    isexist = true;
                }
            }
            Console.WriteLine(isexist);
        }

     

    }
}
