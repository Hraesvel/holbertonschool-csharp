using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary {
    public static void PrintSorted(Dictionary<string, string> myDict) {
        List<String> keys = new List<String>(myDict.Keys.ToList());
        keys.Sort();
        foreach( string k in keys)
            Console.WriteLine("{0}: {1}", k, myDict[k]);
    }
}