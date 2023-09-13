using System;

public class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if(vector1.Length < 2 || vector1.Length > 3 && vector2.Length < 2 || vector2.Length > 3)
        {
            return new double[] { -1 };
        }
        if(vector1.Length != vector2.Length)
        {
            return new double[] { -1 };
        }
        else
        {
            double[] result = new double[vector1.Length];
            for(int i = 0 ; i < vector1.Length ; i++)
            {
              result[i] =  vector1[i] + vector2[i];
            }
            return result;
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
