using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int nodePostion = 0;
        LinkedListNode<int> node = myLList.First;
        while (node != null)
        {
            if(node.Value==value)
            {
                return nodePostion;
            }
            nodePostion++;
            node = node.Next;
        }
        if(nodePostion > 0)
        {
            return -1;
        }
        return nodePostion;
    }
}
