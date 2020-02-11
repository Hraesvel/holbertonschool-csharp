using System;
using System.Collections.Generic;

class List
{
    public static
     List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> a = new HashSet<int>(list1);

        a.SymmetricExceptWith(new HashSet<int>(list2));
        List<int> ls = new List<int>();
        foreach(int i in a)
            ls.Add(i);
        ls.Sort();
        return ls;
    }
}