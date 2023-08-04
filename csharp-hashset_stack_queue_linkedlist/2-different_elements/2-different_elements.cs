using System;
using System.Collections.Generic;


class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (var chiffre1 in list1)
            {
                if(!list2.Contains(chiffre1))
                {
                    newList.Add(chiffre1);
                }
            }
        foreach (var chiffre2 in list2)
            {
                if(!list1.Contains(chiffre2))
                {
                    newList.Add(chiffre2);
                }
            }
        newList.Sort();
        return newList;
    }
}
