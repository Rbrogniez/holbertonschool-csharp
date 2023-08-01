using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> results = new List<bool>();

        for (int i = 0; i < myList.Count; i++)
        {
            int number = myList[i];

            if (number % 2 == 0)
            {
                results.Add(true);
            }
            else
            {
                results.Add(false);
            }
        }

        return results;
    }
}
