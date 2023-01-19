using System;

namespace AlgorithmAndDS
{
    public static class BinaryToDecimalConversion
    {
        public static void BinaryToDecimal()
        {
            Console.Write("Enter a Binary Number: ");
            int num, binVal, decVal = 0, baseVal = 1, rem;
            num = int.Parse(Console.ReadLine());
            binVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decVal = decVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            Console.Write("Binary Number: " + binVal);
            Console.Write("\nDecimal: " + decVal);
            Console.ReadLine();
        }
    }
}
