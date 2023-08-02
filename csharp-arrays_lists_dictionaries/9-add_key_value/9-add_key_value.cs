using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value; // Update the existing key-value pair
        }
        else
        {
            myDict.Add(key, value); // Add a new key-value pair
        }
        return myDict;
    }
}


