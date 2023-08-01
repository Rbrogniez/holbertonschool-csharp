using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count)
            {
                Console.Write("Index is out of range"+"\n");
                return myList;
            }

        else
        {
        for (int i = 0; i < myList.Count; i++)
        {

            if (myList[i] == index)
            {
                myList.Remove(i+1);

            }
        }
        }
        return myList;
    }
}
