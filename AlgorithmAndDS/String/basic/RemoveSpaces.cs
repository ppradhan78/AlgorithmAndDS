using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public static class RemoveSpacesInString
    {
        public static void RemoveSpaces()
        {
            Console.WriteLine("Enter a sentence");
            string str = Convert.ToString(Console.ReadLine());
            if (!string.IsNullOrEmpty(str))
            {
                string[] strArray = str.Split(' ');
                StringBuilder sb = new StringBuilder();
                //foreach (var item in strArray)
                //{
                //    sb.Append(item);
                //}
                for (int i = 0; i < strArray.Length; i++)
                {
                    sb.Append(strArray[i]);
                }
                Console.WriteLine("First Letter Of String: " + sb.ToString());

                //string str = "ma dam git a";
                //string output = "";
                //foreach (char item in str)
                //{
                //    if (!string.IsNullOrEmpty(item.ToString().Trim()))
                //    {
                //        output += item;
                //    }
                //}
            }
        }
    }
}
