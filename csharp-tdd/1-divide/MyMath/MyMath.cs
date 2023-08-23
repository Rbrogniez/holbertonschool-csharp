using System;

namespace MyMath
{

    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if(matrix == null)
            {
                return null;
            }

            int Rows = matrix.GetLength(0);
            int Cols = matrix.GetLength(1);

            int[,] result = new int[Rows, Cols];
            try
            {
                for(int i = 0; i < Rows; i++)
                {
                    for(int j = 0; j < Cols; j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return result;
        }

    }
}
