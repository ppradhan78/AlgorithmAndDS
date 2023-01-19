using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class ReverseOfString
    {
        public static void  ReverseOfAString()
        {
            Console.WriteLine("Reverse Of String");
            Console.WriteLine("_________________");
            Console.WriteLine("Enter a  String");
            var x = Console.ReadLine();
            if (x != null && x.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                string[] strings = x.Split(' ');
                for (int i = strings.Length - 1; i >= 0; i--)
                {
                    sb.Append(strings[i] + " ");
                }
                sb.Append(Environment.NewLine);
                sb.Append("______foreach________");
                sb.Append(Environment.NewLine);
                foreach (var item in strings.Reverse())
                {
                    sb.Append(item + " ");
                }
                Console.Write(sb.ToString());
            }
            Console.ReadKey();
        }

        public static void ReverseOfAString_No_Lib()
        {
            string str = "Prasanta Kumar Pradhan ";
            ArrayList arrayList = new ArrayList();
            string Temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                //if (str[i] != ' ')
                //{
                //    Temp = Temp + str[i];
                //    continue;
                //}
                //arrayList.Add(Temp);
                //Temp = "";
                //OR
                if (str[i] == ' ')
                {
                    arrayList.Add(Temp);
                    Temp = "";
                }
                Temp = Temp + str[i];

            }
            StringBuilder sb = new StringBuilder();
            for (int i = arrayList.Count-1; i >=0 ; i--)
            {
                sb.Append(arrayList[i] + " ");
            }
            sb.Append(Environment.NewLine);
            sb.Append("______Without Lib________");
            sb.Append(Environment.NewLine);
            Console.Write(sb.ToString());
        }
    }
}
