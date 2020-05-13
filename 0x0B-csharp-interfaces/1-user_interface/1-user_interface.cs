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