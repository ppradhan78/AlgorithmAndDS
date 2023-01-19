using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Number
{
    public static class GCD
    {
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }
        public static void FindGCD()
        {
            Console.WriteLine("GCD of Two Number");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
           int _gcd= gcd(a, b);
            Console.WriteLine("GCD of Two Number : "+a+","+b+" is: "+_gcd);
        }
    }
}
