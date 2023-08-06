using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Invalid index");
        }

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        while (currentIndex < index)
        {
            current = current.Next;
            currentIndex++;
        }

        myLList.Remove(current);
    }
}
