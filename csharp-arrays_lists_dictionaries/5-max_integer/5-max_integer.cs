using System;
using System.Collections.Generic;


class List
{
    public static int MaxInteger(List<int> myList)
    {
     if(myList.Count == 0)
     {
        Console.Write("List is empty ");
        return -1;
     }
     else
     {
     int MaxInteger = myList[0];
     for (int i = 1; i < myList.Count; i++)
     {
        if (myList[i] > MaxInteger)
        {
            MaxInteger = myList[i];
        }
     }
     return MaxInteger;
     }
    }
}
