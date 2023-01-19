using System;

namespace AlgorithmAndDS
{
    public static class PalindromeNumber
    {
        public static void IsPalindromeNumber()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("          Check Palindrome Number             ");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Enter Your Number To Check :: ");
            
            int num, rem, temp=0, sum = 0 ;
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
            }
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }
}
