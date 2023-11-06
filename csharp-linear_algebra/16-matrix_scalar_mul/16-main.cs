using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { -2, 1 }, { 7, 9 } };
        double[,] result;

        result = MatrixMath.MultiplyScalar(matrix, 8);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
