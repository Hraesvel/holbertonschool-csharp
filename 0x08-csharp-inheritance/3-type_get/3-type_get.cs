using System;
using static System.Console;
using System.Reflection;

/// <summary>
/// Obj class
/// </summary>
class Obj {
    /// <summary>
    /// checks if a value is of type int
    /// </summary>
    /// <param obj="value ti inspect"></param>
    /// <returns> true else flase</returns>
    public static bool IsOfTypeInt(object obj)
    {
    return obj.GetType() == typeof(int) ? true : false;
    }

/// <summary>
/// checks if a value is an instance of class Array.
/// </summary>
/// <param obj="value to inspect"></param>
/// <returns>bool</returns>
    public static bool IsInstanceOfArray(object obj) {
        return obj is Array ? true : false;
    }

    /// <summary>
    /// Check if a type is a subclass of another.
    /// </summary>
    /// <param derivedType="derivedType"></param>
    /// <param baseType="baseType"></param>
    /// <returns></returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        return derivedType.IsSubclassOf(baseType);
    }

    public static void Print(object myObj) {
        TypeInfo t = myObj.GetType().GetTypeInfo();
    var prop = t.DeclaredProperties;
    var method = t.DeclaredMethods;
    WriteLine("{0} Properties", myObj.GetType().Name);
    foreach (var i in prop)
            WriteLine(i.Name);
    WriteLine("{0} Methods", myObj.GetType().Name);
    foreach (var i in method)
        if (i.IsPublic)
            WriteLine(i.Name);
    }
}