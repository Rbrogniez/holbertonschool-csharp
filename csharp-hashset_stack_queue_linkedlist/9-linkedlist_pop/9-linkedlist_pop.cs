using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == null)
        {
            return 0;
        }
        else
        {
        LinkedListNode<int> firstNode = myLList.First;
        return firstNode.Value;
        }
    }
}
