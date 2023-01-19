using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public static class FirstLetterOfString
    {
        public static void FirstLetter()
        {
            Console.WriteLine("Enter a sentence");
            string str = Convert.ToString(Console.ReadLine());
            if (!string.IsNullOrEmpty(str))
            {
                string[] strArray = str.Split(' ');
                StringBuilder sb = new StringBuilder();
                foreach (var item in strArray)
                {
                    if (item.Length>0)
                    {
                        char[] charArray = item.ToCharArray();
                        if (charArray.Length>0)
                        {
                            sb.Append( charArray[0]);
                        }
                    }
                }
                Console.WriteLine("First Letter Of String: " + sb.ToString());
            }
         
        }

        public static void FirstLetter_1()
        {
            Console.WriteLine("Enter a sentence");
            string str = "Prasanta kumar pradhan"; //Convert.ToString(Console.ReadLine());
            if (!string.IsNullOrEmpty(str))
            {
                string[] strArray = str.Split(' ');
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < strArray.Length; i++)
                {
                    char[] charArray = strArray[i].ToCharArray();
                    sb.Append(charArray[0]);
                }
                Console.WriteLine("First Letter Of String: " + sb.ToString());
            }

        }
    }
}
