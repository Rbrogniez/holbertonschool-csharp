using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int numberItem = 0;
        foreach (var item in myLList)
        {
            numberItem += 1;
        }
        return numberItem;
    }
}
