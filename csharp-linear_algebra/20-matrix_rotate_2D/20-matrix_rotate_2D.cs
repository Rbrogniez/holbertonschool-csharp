using System;
using System.Windows.Media;

/// <summary>
/// New matrix class calculation
/// </summary>
class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        matrix.Rotate(angle);
        return matrix;
    }
}
