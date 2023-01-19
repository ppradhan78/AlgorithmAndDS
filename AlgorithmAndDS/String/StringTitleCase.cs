using System;
using System.Text;

namespace AlgorithmAndDS
{
    public static class StringTitleCase
    {
        public static void convertToTitleCaseIteratingChars()
        {
            Console.Write("Enter a String: ");
            string str = Convert.ToString(Console.ReadLine());
            StringBuilder converted = new StringBuilder();
            bool convertNext = true;
            char items = ' ';
            foreach (char item in str.ToCharArray())
            {
                if (char.IsWhiteSpace(item))
                {
                    convertNext = true;
                    converted.Append(" ");
                    items = ' ';
                }
                else if (convertNext)
                {
                    items = char.ToUpper(item);
                    convertNext = false;
                }
                else
                {
                    items = char.ToLower(item);
                }
                converted.Append(items);
            }
            Console.WriteLine(converted.ToString());
        }


    }
}
