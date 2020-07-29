using System;

class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
    public int durability { get; set; }

    /// <summary>
    /// Constroctor for Decoration
    /// </summary>
    /// <param name="name">name of Decoration, defaults to `Dectoration`</param>
    /// <param name="durability">objects Durabilty (HP)</param>
    /// <param name="isQuestItem">Flag if is a Quest item</param>
    public Decoration(
        string name = "Decoration",
        int durability = 1,
        bool isQuestItem = false
    )
    {
        if (durability <= 0)
            throw new System.Exception("Durability must be greater than 0");

        this.isQuestItem = isQuestItem;
        this.name = name;
        this.durability = durability;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The {0} has been broken.", name);
            return;
        }

        if (isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    public void Break()
    {
        durability -= 1;

        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else
            Console.WriteLine("The {0} is already broken.", name);
    }
}


/// <summary>
/// Door type
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor
    /// </summary>
    /// <param name="name">name of door, defaults to "Door"</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// perform Interact action
    /// </summary>
    public void Interact()
    {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}


/// <summary>
/// Make object intractable
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// give objects a durability property and breakable state
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// make an object collectible.
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }

    void Collect();
}

/// <summary>
/// Base class for object to Inherit
/// </summary>
public abstract class Base
{
    /// <summary>
    /// public name of object
    /// </summary>
    public string name;

    /// <summary>
    /// return a message
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().Name);
    }
}