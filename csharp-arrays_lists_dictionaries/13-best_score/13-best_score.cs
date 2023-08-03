using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxScore = int.MinValue;
        string bestStudent = "None";

        foreach (var kvp in myList)
        {
            if (kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                bestStudent = kvp.Key;
            }
        }

        return bestStudent;
    }
}
