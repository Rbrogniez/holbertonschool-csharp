using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int NumberKeys = 0;
        foreach (var keys in myDict)
        {
            NumberKeys++;
        }
        return NumberKeys;
    }
}
