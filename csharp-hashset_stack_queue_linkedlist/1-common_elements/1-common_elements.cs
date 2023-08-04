using System;
using System.Collections.Generic;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();

        foreach (var item1 in list1)
        {
            foreach (var item2 in list2)
                {
                    if (item1 == item2)
                    {
                        newList.Add(item1);
                    }
                }
        }
            return newList;
    }
}
