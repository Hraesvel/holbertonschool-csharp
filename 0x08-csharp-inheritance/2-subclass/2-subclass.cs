using System;
using static System.Console;

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
}