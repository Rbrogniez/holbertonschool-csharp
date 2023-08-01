using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> mylist;
        
        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }

        else
        {
        mylist = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            mylist.Add(i);
        }

        for (int i = 0; i < mylist.Count; i++)
        {
            Console.Write(mylist[i]+" ");
        }
        }
        Console.WriteLine();
        return mylist;
    }
}
