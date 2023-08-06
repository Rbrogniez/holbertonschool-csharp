using System;
using System.Collections.Generic;

public class List
{
    public static int Sum(List<int> myList)
    {
        // Create a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>();

        // Iterate through the list and add unique integers to the HashSet
        foreach (int num in myList)
        {
            if (!uniqueIntegers.Contains(num))
            {
                uniqueIntegers.Add(num);
            }
        }

        // Sum up the unique integers in the HashSet
        int sum = 0;
        foreach (int uniqueNum in uniqueIntegers)
        {
            sum += uniqueNum;
        }

        return sum;
    }
}

       // List<int> distinctList = myList.Distinct().ToList();
       // return distinctList.Sum();
       // HashSet<int> uniqueElements = new HashSet<int>(myList);
       // return uniqueElements.Sum();
