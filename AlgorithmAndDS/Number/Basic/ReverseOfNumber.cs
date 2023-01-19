using System;

namespace AlgorithmAndDS
{
    public static class ReverseOfNumber
    {
        public static void GetReverseOfNumber()
        {
            int n,  m;
            string sum = "";
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Reverse Of Number Is= " + sum);
            Console.ReadLine();
        }
    }
}
