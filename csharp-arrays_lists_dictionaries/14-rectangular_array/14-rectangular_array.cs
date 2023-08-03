using System;
using System.Collections.Generic;

public static class Array
{
    static void Main(string[] args)
    {
        int [,] Matrice = new int [5,5];
        Matrice[2, 2] = 1;
        for (int i=0; i<Matrice.GetLength(0); i++)
         {
            for (int j=0; j<Matrice.GetLength(1); j++)
                {
                    Console.Write($"{Matrice[i,j]} ");
                }
                Console.Write("\n");
         }
    }
}


