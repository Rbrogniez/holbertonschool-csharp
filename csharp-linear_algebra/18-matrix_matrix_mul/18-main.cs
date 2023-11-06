using System;

class Program
{
    static void Main()
    {
        double[,] matrix1 = {
            {1, 2},
            {3, 4}
        };

        double[,] matrix2 = {
            {5, 6},
            {7, 8}
        };

        double[,] result = MatrixMath.Multiply(matrix1, matrix2);

        if (result.GetLength(0) == 1 && result.GetLength(1) == 1 && result[0, 0] == -1)
        {
            Console.WriteLine("Les matrices ne peuvent pas être multipliées.");
        }
        else
        {
            Console.WriteLine("Résultat de la multiplication des matrices :");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
