using System;

// Définition de la classe MatrixMath
class MatrixMath
{
    // Déclaration de la méthode Add
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Vérification de la compatibilité des matrices pour l'addition
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || // Si matrix1 n'est pas carrée
            matrix2.GetLength(0) != matrix2.GetLength(1) || // Si matrix2 n'est pas carrée
            matrix1.GetLength(0) != matrix2.GetLength(0))   // Si les dimensions des matrices ne correspondent pas
        {
            // Retourne une matrice 2x2 contenant la valeur -1 pour indiquer une erreur
            return new double[1, 1] { { -1 } };
        }
        else
        {
            // Création d'une nouvelle matrice pour stocker le résultat de l'addition
            double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

            // Boucles imbriquées pour parcourir les éléments des matrices et effectuer l'addition
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // Addition des éléments correspondants de matrix1 et matrix2
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Retourne la matrice résultante après l'addition
            return result;
        }
    }
}
