using System;

namespace AlgorithmAndDS
{
    public static class CheckPrimeNumber
    {
        static int i = 2;
        public static void IsPrime()
        {
            //numbers that have only 2 factors: 1 and themselves
            Console.WriteLine("Check the number Is Prime or not, Enter a Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (Prime(n))
            {
                Console.WriteLine("Number is  Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
            Console.ReadLine();
        }
        private static bool Prime(int n)
        {
            // corner cases
            if (n == 0 || n == 1)
            {
                return false;
            }
            // Checking Prime
            if (n == i)
            {
                return true;
            }
            // base cases
            if (n % i == 0)
            {
                return false;
            }
            i++;
            return Prime(n);
        }
       
    }
}
