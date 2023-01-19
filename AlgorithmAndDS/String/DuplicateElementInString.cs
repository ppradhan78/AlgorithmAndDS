using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmAndDS.String
{
    public static class DuplicateElementInString
    {
        public static void Remove_All_Duplicates_From_String()
        {
            string input = "Prasanta";
            Console.WriteLine(new string(input.ToCharArray().Distinct().ToArray()));

            string newString = string.Empty;
            List<char> found = new List<char>();
            foreach (char c in input)
            {
                if (found.Contains(c))
                    continue;

                newString += c.ToString();
                found.Add(c);
            }
            Console.WriteLine(newString);
        }
    }
}
