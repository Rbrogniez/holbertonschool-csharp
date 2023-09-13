using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1 && matrix2 < 2 || matrix1 && matrix2 > 3 || matrix1 != matrix2)
        {
            return new double[,] {{-1}};
        }

        else
        {
            double[,] result = new double (matrix1.GetLength(0), matrix1.GetLength(1));
            for( i = 0; matrix1.GetLength(0); i++)
            {

                for (j = 0 ; matrix1.GetLength(1); j++)
                {
                    result matrix1[i,j] + matrix2[i,j];
                }
            }
            return result;
        }
    }
}
