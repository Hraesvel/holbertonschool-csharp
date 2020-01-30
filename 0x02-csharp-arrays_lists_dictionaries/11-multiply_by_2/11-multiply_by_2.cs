using System.Collections.Generic;

class Dictionary {
    public static Dictionary<string, int> 
    MultiplyBy2(Dictionary<string, int> myDict){
        Dictionary<string, int> newDict =  new Dictionary<string, int>();
        foreach((string k, int v) in myDict){
            newDict.Add(k, v * 2);
        }
        return newDict;
    }
}