
using System;

/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
public class Queue<T>
{
    /// <summary>
    /// check Queue base type
    /// </summary>
    /// <returns>string rep of base type</returns>
    public string CheckType()
    {
        var t = this.GetType().BaseType;
        return t.ToString();
    }
} 