using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Create a new generic collection of type T objects that can be iterated through using `foreach`
/// </summary>
/// <typeparam name="T"> Interface type</typeparam>
class Objs<T> : IEnumerable<T>
{
    private List<T> lot = new List<T>();
    
    public IEnumerator<T> GetEnumerator()
    {
        return lot.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public void Add(T item)
    {
      lot.Add(item);   
    }
}