using System;

/// <summary>
/// Player class
/// </summary>
public class Player {
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player Constructor
    /// </summary>
    /// <param name="name">Defaulted to "Player"</param>
    /// <param name="maxHp">Defaulted to 100.0f</param>
    public Player (string name = "Player", float maxHp = 100f) {
        if (string.IsNullOrEmpty(name))
            name = "Player";

        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine ("maxHp must be greater than 0. maxHp set to 100f by default");
            maxHp = 100f;
        }
        this.hp = this.maxHp = maxHp;
    }

    /// <summary>
    /// Prints player health as message
    /// </summary>
    public void PrintHealth(){
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}