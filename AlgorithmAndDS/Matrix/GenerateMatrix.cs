using System;

namespace AlgorithmAndDS
{
    public static class GenerateMatrix
    {
        public static void Print3X3Matrix()
        {
            Generate3X3Matrix();
            Console.ReadLine();
        }

        private static void Generate3X3Matrix()
        {
            int Row, Column;
            int[,] arr1 = new int[3, 3];

            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (Row = 0; Row < 3; Row++)
            {
                for (Column = 0; Column < 3; Column++)
                {
                    Console.Write("element - [{0},{1}] : ", Row, Column);
                    arr1[Row, Column] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("------------------------3X3------------------------\n");
            Console.Write("\nThe matrix is : \n");
            for (Row = 0; Row < 3; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 3; Column++)
                    Console.Write("{0}\t", arr1[Row, Column]);
            }
            Console.Write("\n\n");
        }

        public static void Generate4X4Matrix_Edg_InnerMatrix()
        {
            int Row, Column;
            int[,] arr1 = new int[4, 4]
           { { 1,2,3,4},{ 5,6,7,8},{ 9,10,11,12},{13,14,15,16} };

            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                    Console.Write("{0}\t", arr1[Row, Column]);
                //Console.Write(arr1[Row, Column]);
            }
            Console.Write(Environment.NewLine);

            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                    if (
                        (Row == 0 && Column == 0) || (Row == 0 && Column == 3)
                    || (Row == 3 && Column == 0) || (Row == 3 && Column == 3)

                    )
                    {
                        Console.Write("{0}\t\t\t", arr1[Row, Column]);
                    }
                    else if (
                        (Row == 1 && Column == 1) || (Row == 1 && Column == 2)
                  || (Row == 2 && Column == 1) || (Row == 2 && Column == 2)
                  )
                    {
                        Console.Write("{0}\t", arr1[Row, Column]);
                    }

            }
        }




    }
}
