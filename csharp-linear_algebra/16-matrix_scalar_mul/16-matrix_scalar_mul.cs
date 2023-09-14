using System;

// Définit une classe appelée MatrixMath.
class MatrixMath
{
    // Déclare une méthode statique MultiplyScalar.
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Vérifie si la matrice n'est pas carrée.
        if(matrix.GetLength(0) != matrix.GetLength(1))
        {
            // Renvoie une nouvelle matrice 1x1 avec la valeur -1 pour indiquer une erreur.
            return new double[1,1] {{-1}};
        }
        else
        {
            // Crée une nouvelle matrice pour stocker le résultat.

            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
            // Parcourt les lignes de la matrice.
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                // Parcourt les colonnes de la matrice.
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                      // Multiplie chaque élément de la matrice par le scalaire et le stocke dans la matrice résultante.
                    result[i,j] = matrix[i,j] * scalar;
                }
            }
            // Renvoie la matrice résultante.
            return result;
        }
    }
}
