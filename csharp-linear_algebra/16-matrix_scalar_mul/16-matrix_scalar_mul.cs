using System;


class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if(matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[1,1] {{-1}};
        }
        else
        {
            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i,j] = matrix[i,j] * scalar;
                }

            }
            return result;
        }
    }

}
