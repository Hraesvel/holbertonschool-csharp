using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList) {
        List<bool> check = new List<bool>();
        if (myList.Count == 0)
            return check;
        foreach(int i in myList){
            check.Add(i % 2 == 0 ? true : false);
        }
        return check;
    }    
}