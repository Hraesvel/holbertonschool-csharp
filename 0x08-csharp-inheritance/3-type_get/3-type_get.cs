using System;
using static System.Console;
using System.Reflection;

class Obj {

    /// <summary>
    ///  prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param myObj="object to inspect"></param>
    public static void Print (object myObj) {
        var t = myObj.GetType().GetTypeInfo();

        var prop = t.GetProperties ();
        var method = t.GetMethods ();
        
        WriteLine ("{0} Properties:", t.Name);
        foreach (var i in prop)
                WriteLine (i.Name);

        WriteLine ("{0} Methods:", t.Name);
        foreach (var i in method)
            if (i.IsPublic)
                WriteLine (i.Name);
    }
}