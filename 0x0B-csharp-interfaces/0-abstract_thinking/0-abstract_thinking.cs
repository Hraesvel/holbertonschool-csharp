using System;

abstract class Base {
    /// <summary>
    /// public name of object
    /// </summary>
    public string name;

    protected Base(string name)
    {
        this.name = name;
    }

    /// <summary>
    /// return a message
    /// </summary>
    /// <returns>string</returns>
    public override string ToString(){
        return string.Format("{0} is a {1}", name, this.GetType().Name);
    }
}