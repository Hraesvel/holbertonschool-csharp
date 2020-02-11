using System;
using System.Linq;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> unique = myList.ToHashSet();
        return unique.Sum();
    }
}