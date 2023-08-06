using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLinkedList = new LinkedList<int>();

        for (int i = 0; i <= size; i++)
        {
            newLinkedList.AddLast(i);
        }

        foreach(int number in newLinkedList)
        {
            Console.WriteLine(number);
        }

        return newLinkedList;
    }
}

