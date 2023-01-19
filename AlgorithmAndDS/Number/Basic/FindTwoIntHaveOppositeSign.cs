using System;

namespace AlgorithmAndDS
{
    /// <summary>
    /// https://www.geeksforgeeks.org/detect-if-two-integers-have-opposite-signs/?ref=lbp
    /// Detect if two integers have opposite signs
    /// </summary>
    public static class TwoIntHaveOppositeSign
    {
        static bool oppositeSigns(int x, int y)
        {
            return ((x ^ y) < 0);
        }

        // Driver Code 
        public static void FindTwoIntHaveOppositeSign()
        {
            Console.WriteLine("Enter two Number:");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
          
            if (oppositeSigns(x, y) == true)
                Console.Write("Signs are opposite");
            else
                Console.Write("Signs are not opposite");


            Console.ReadKey();
        }
    }

}
