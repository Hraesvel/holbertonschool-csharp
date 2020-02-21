using System;
using static System.Console;
using System.Reflection;

class Obj {

    /// <summary>
    ///  prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param myObj="object to inspect"></param>
    public static void Print(object myObj) {
        TypeInfo t = myObj.GetType ().GetTypeInfo ();
        var prop = t.DeclaredProperties;
        var method = t.DeclaredMethods;
        WriteLine ("{0} Properties", myObj.GetType ().Name);
        foreach (var i in prop)
            WriteLine (i.Name);
        WriteLine ("{0} Methods", myObj.GetType ().Name);
        foreach (var i in method)
            if (i.IsPublic)
                WriteLine (i.Name);
    }
}