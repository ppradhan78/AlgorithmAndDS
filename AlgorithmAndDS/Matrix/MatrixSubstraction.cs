using System;

namespace AlgorithmAndDS
{
    public static class MatrixSubstraction
    {
        public static void SubstractionMatrix()
        {
            int Row, Column;
            int[,] arr1 = new int[4, 4]
           { { 1,2,3,4},{ 5,6,7,8},{ 9,10,11,12},{13,14,15,16} };

            int[,] arr2 = new int[4, 4]
           { { 1,2,3,4},{ 5,6,7,8},{ 9,10,11,12},{13,14,15,16} };

            int[,] arr3 = new int[4, 4];

            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                    Console.Write("{0}\t", arr1[Row, Column]);

            }
            Console.Write(Environment.NewLine);

            for (Row = 0; Row < 4; Row++)
            {

                for (Column = 0; Column < 4; Column++)
                    arr3[Row, Column] = arr1[Row, Column] - arr2[Row, Column];

            }

            Console.WriteLine("Matrix Substraction ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

    }
}
