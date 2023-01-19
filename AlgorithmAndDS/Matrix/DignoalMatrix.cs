using System;

namespace AlgorithmAndDS
{
    public static class DignoalMatrix
    {
        public static void Generate4X4Matrix_Dignoal()
        {
            int Row, Column;
            int[,] arr1 = new int[4, 4]
           { { 1,2,3,4},{ 5,6,7,8},{ 9,10,11,12},{13,14,15,16} };

            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                    Console.Write("{0}\t", arr1[Row, Column]);

            }
            Console.Write(Environment.NewLine);

            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                    if (
                       (Row == 0 && Column == 0) ||
                        (Row == 1 && Column == 1) ||
                         (Row == 2 && Column == 2) ||
                          (Row == 3 && Column == 3)
                        )
                        Console.Write("{0}\t", arr1[Row, Column]);

            }
        }

    }
}
