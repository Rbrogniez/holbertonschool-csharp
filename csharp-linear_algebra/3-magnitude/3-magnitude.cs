using System;

class VectorMath
{
    // Méthode pour calculer la magnitude d'un vecteur
    // Prend un tableau de doubles en entrée représentant le vecteur
    public static double Magnitude(double[] vector)
    {
        // Vérifie si le vecteur est 2D
        if (vector.Length == 2)
        {
            double x = vector[0];
            double y = vector[1];
            // Calcul de la magnitude d'un vecteur 2D : sqrt(x^2 + y^2)
            double result = Math.Sqrt(x * x + y * y);
            // Arrondir le résultat à deux décimales
            return Math.Round(result, 2);
        }

        // Vérifie si le vecteur est 3D
        else if (vector.Length == 3)
        {
            double x = vector[0];
            double y = vector[1];
            double z = vector[2];
            // Calcul de la magnitude d'un vecteur 3D : sqrt(x^2 + y^2 + z^2)
            double result = Math.Sqrt(x * x + y * y + z * z);
            // Arrondir le résultat à deux décimales
            return Math.Round(result, 2);
        }

        // Si le vecteur n'est ni 2D ni 3D, retourne -1 pour indiquer une erreur
        else
        {
            return -1;
        }
    }
}

/// Autre méthode différente

/// public static double Magnitude(double[] vector)
///     {
///         double result = 0;
///
///         for (int i = 0; i < vector.Length; i++)
///         {
///             result += Math.Pow(vector[i],2);
///         }
///
///         result = Math.Sqrt(result);
///         result = Math.Round(result,2);
///         return result;
///     }
