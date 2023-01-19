using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.Number
{
    public static class LCM
    {
        public static int lcm(int a, int b)
        {
            return (a / gcd(a, b)) * b;
        }
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
           int _gcd= lcm(a, b);
            Console.WriteLine("GCD of Two Number : "+a+","+b+" is: "+_gcd);
        }
    }
}
