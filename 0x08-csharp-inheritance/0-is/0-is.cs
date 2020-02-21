using System;
using static System.Console;

class Obj {
    /// <summary>
    /// checks if a value is of type int
    /// </summary>
    /// <param obj="obj to inspect"></param>
    /// <returns> true else flase</returns>
    public static bool IsOfTypeInt(object obj)
    {
    return obj.GetType() == typeof(int) ? true : false;
    }
}