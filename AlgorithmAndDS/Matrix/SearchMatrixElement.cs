using System;

namespace AlgorithmAndDS
{
    public static class SearchMatrixElement
    {
        public static void Print3X3Matrix()
        {
            bool isfound = false;
            int Row, Column;
            int[,] mat = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
            int searchElement = 10;
            for (Row = 0; Row < 4; Row++)
            {
                Console.Write("\n");
                for (Column = 0; Column < 4; Column++)
                {
                    if (mat[Row, Column] == searchElement)
                    {
                        isfound = true;

                    }
                }
            }
            if (isfound)
                Console.Write("Element found");
            else
                Console.Write("Element not found");
        }
    }
}
