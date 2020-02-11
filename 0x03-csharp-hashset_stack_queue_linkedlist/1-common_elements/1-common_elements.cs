using System;
using System.Collections.Generic;

class List
{
    public static
    List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> a = new HashSet<int>(list1);
        HashSet<int> b = new HashSet<int>(list2);
        a.IntersectWith(b);
        List<int> ls = new List<int>();

        foreach(int i in a)
            ls.Add(i);
        
        ls.Sort();

        return ls;

    }
}