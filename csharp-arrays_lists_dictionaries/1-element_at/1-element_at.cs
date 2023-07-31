using System;


class Array
{
    public static int elementAt(int[] array, int index)
    {

        if (index < 0 || index >= array.Length)
        {
            Console.Write("Index out of range"+"\n");
            return -1;
        }
        else
        {
            return array[index];
        }

    }
}
