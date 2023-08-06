using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int nodePosition = 0;
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if (node.Value == value)
            {
                return nodePosition;
            }
            nodePosition++;
            node = node.Next;
        }
        return -1;
    }
}
