using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.String
{
    public static class LengthOfString
    {
        public static void GetLengthOfString()
        {
            Console.WriteLine("Enter a string:");
            string str = Convert.ToString(Console.ReadLine());
            int counter = 0;
            foreach (char item in str)
            {
                counter += 1;
            }
            Console.WriteLine("Length of string:"+ counter);
            counter = 0;
            foreach (char item in str)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                {
                    counter += 1;
                }
            }
            Console.WriteLine("Length of string without space:" + counter);
        }
    }
}
