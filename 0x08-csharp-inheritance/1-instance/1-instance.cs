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
}