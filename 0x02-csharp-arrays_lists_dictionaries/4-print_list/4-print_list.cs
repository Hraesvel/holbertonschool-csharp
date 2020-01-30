using System;
using System.Linq;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        var ls = Enumerable.Range(0, size).ToList();
        Console.WriteLine("{0}", string.Join(" ", ls));
        return ls;
    }
}