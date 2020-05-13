﻿using System;

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

    public void Interact()
    {
        System.Console.WriteLine($"You try to open the {this.name}. It's locked");
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