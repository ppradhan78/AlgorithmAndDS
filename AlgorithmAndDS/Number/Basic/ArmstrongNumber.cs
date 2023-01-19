using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS
{
    public static class ArmstrongNumber
    {
        public static void IsArmstrongNumber1()
        {
           
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Number Is Armstrong Or Not             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Your Number To Check :: ");
            
            int number, rem, temp, sum = 0;
            number = 153;// int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadKey();
        }
        /// <summary>
        /// 153 = 1*1*1 + 5*5*5 + 3*3*3 // 153
        /// </summary>
        public static void IsArmstrongNumber()
        {

            string num = "153";
            char[] chrs = num.ToCharArray();
            int sum = 0;
            foreach (char item in chrs)
            {
                int temp =int.Parse( item.ToString());
                sum = temp * temp * temp;
                temp = 0;
            }
            if (sum.ToString() == num)
                Console.WriteLine(" Is A Armstrong Number");
            else
                Console.WriteLine(" Is Not A Armstrong Number");
        }
    }
}
