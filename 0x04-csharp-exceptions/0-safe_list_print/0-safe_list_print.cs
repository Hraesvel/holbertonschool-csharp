using System;
using System.Collections.Generic;
using static System.Console;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;
        if (myList.Count == 0)
            return i;

        try
        {
            for (i = 0; i < n; i++)
                Console.WriteLine(myList[i]);
        }
        catch (System.ArgumentOutOfRangeException) { }

        return i;
    }
}