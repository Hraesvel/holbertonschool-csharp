using System;


/// <summary>
/// Deleagate for calculating health
/// </summary>
/// <param name="damage"></param>
public delegate void CalculateHealth(float damage);

/// <summary>
/// Player class
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player Constructor
    /// </summary>
    /// <param name="name">Defaulted to "Player"</param>
    /// <param name="maxHp">Defaulted to 100.0f</param>
    public Player (string name = "Player", float maxHp = 100f) {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine ("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        hp = this.maxHp = maxHp;
    }

    /// <summary>
    /// Prints player health as message
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    

    
    
    /// <summary>
    /// Action for taking damage to "hp"
    /// </summary>
    /// <param name="damage">amount to subtract</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        // hp -= damage;
    }

    /// <summary>
    /// Action for healing to "hp
    /// </summary>
    /// <param name="heal">amount to add</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        // hp += heal;
    }
}

