using System;

public static class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] arr;

        if (size == 0)
            {
                Console.WriteLine();
            }
        if (size < 0)
            {
                Console.Write("Size cannot be negative"+"\n");
                return null;
            }
        else
            {
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]+"\n");
                }
                else
                {
                Console.Write(arr[i]+" ");
                }
            }
            }
        return arr;
    }
}
