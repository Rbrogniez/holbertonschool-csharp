using System;

class VectorMath
{
    // Méthode pour calculer le produit scalaire de deux vecteurs
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Vérification des conditions pour effectuer le calcul du produit scalaire
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
            return -1; // Retourne -1 si les conditions ne sont pas remplies

        double result = 0; // Initialise une variable pour stocker le résultat du produit scalaire

        // Boucle pour parcourir les éléments des deux vecteurs
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i]; // Calcule le produit des éléments correspondants et l'ajoute au résultat
        }

        return result; // Retourne le résultat du produit scalaire
    }
}
