using System;

/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
public class Queue<T> {
    /// <summary>
    /// check Queue base type
    /// </summary>
    /// <returns>string rep of base type</returns>
    public Type CheckType () {
        return typeof (T);
    }
}