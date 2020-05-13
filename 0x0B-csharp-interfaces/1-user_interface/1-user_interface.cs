/// <summary>
/// Base class for object to Inherit
/// </summary>
public abstract class Base {
    /// <summary>
    /// public name of object
    /// </summary>
    public string name;
    
    /// <summary>
    /// return a message
    /// </summary>
    /// <returns>string</returns>
    public override string ToString(){
        return string.Format("{0} is a {1}", name, this.GetType().Name);
    }
}

/// <summary>
/// Make object intractable
/// </summary>
public interface IInteractive
{
    void Interact();
}

/// <summary>
/// give objects a durability property and breakable state
/// </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// make an object collectible.
/// </summary>
public interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}