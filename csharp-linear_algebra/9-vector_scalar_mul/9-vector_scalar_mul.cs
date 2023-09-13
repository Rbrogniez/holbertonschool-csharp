using System;

class VectorMath
{
    // Méthode pour multiplier un vecteur par un scalaire
    public static double[] Multiply(double[] vector, double scalar)
    {
        // Vérifier si la longueur du vecteur est inférieure à 2 ou supérieure à 3
        if (vector.Length < 2 || vector.Length > 3)
        {
            // Si la condition ci-dessus est remplie, retourner un tableau contenant -1
            return new double[] { -1 };
        }

        // Créer un tableau résultat de la même longueur que le vecteur d'entrée
        double[] result = new double[vector.Length];

        // Parcourir le vecteur d'entrée et multiplier chaque élément par le scalaire
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        // Retourner le résultat de la multiplication
        return result;
    }
}
