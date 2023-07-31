using System;
using System.Collections.Generic;

    class Array
    {
        public static void Reverse(int[] array)
        {

        if (array == null)
        {
            Console.Write("\n");
            return;
        }
        else
        {
        System.Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+"  ");
        }
        }
        Console.Write("\n");

        }
    }
