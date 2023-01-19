//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AlgorithmAndDS.String
//{
//    public static class ReverseAlternateWords
//    {
//        // prasanta kumar pradhan prasanta-> prasanta ramuk pradhan  atnasarp
//        public static void Reverse()
//        {
//            Console.WriteLine("Enter a sentence");
//            string str = Convert.ToString(Console.ReadLine());
//            if (!string.IsNullOrEmpty(str))
//            {
//                string[] strArray = str.Split(' ');
//                StringBuilder sb = new StringBuilder();
               
//                bool isReverse = false;
//                for (int i = 0; i < strArray.Length; i++)
//                {
//                    if (i==0)
//                    {
//                        sb.Append(strArray[0]);
//                        sb.Append(" ");
//                    }
//                    char[] charArray = strArray[i].ToCharArray();
//                    string charStr = string.Empty;
//                    for (int j = charArray.Length-1; j >=0; j--)
//                    {
//                         charStr += charArray[j];
//                    }
//                    sb.Append(" ");
//                    sb.Append(charStr);
//                    i = i + 1;
//                }
               
//                Console.WriteLine("Reverse Alternate Word in string: " + sb.ToString());
//            }
//        }
//    }
//}
