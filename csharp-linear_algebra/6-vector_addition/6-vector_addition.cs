using System;

public class VectorMath
{
    // Méthode pour additionner deux vecteurs
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Vérifier si la longueur des vecteurs est inférieure à 2 ou supérieure à 3
        if (vector1.Length < 2 || vector1.Length > 3 && vector2.Length < 2 || vector2.Length > 3)
        {
            // Si les conditions ci-dessus sont remplies, retourner un tableau contenant -1
            return new double[] { -1 };
        }

        // Vérifier si les longueurs des vecteurs ne correspondent pas
        if (vector1.Length != vector2.Length)
        {
            // Si les longueurs ne correspondent pas, retourner un tableau contenant -1
            return new double[] { -1 };
        }
        else
        {
            // Si les longueurs des vecteurs sont valides et correspondent, effectuer l'addition
            double[] result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] + vector2[i];
            }
            // Retourner le résultat de l'addition
            return result;
        }
    }
}

   // public static void Main()
   // {
   //     // Test cases
   //     double[] vector1 = { 27.0, 39.0 }; // 3D vector
   //     double[] vector2 = { 4.0, 5.0, 6.0 }; // 3D vector
   //     double[] result = Add(vector1, vector2);
    //
   //     Console.WriteLine("Resultant Vector:");
   //     foreach (var value in result)
   //     {
   //         Console.WriteLine(value);
   //     }
   // }
}
