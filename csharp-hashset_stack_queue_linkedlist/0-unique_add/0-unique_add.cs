using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {

       // List<int> distinctList = myList.Distinct().ToList();
       // return distinctList.Sum();
       HashSet<int> uniqueElements = new HashSet<int>(myList);
       return uniqueElements.Sum();
    }

}
