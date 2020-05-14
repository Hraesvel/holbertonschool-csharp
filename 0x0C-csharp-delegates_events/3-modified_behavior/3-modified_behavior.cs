using System;

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
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }

        hp = this.maxHp = maxHp;
    }

    /// <summary>
    /// Prints player health as message
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health.");
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
        ValidateHP(hp - damage);
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
        ValidateHP(hp + heal);
    }

    /// <summary>
    /// Validates "newHp" and updates "hp"
    /// </summary>
    /// <param name="newHp">amount to modify "hp" by pre-validation</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0f;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    /// <summary>
    /// applies damage/heal modifier to value
    /// </summary>
    /// <param name="baseValue">value to be modified</param>
    /// <param name="modifier"> enum for possible modifications</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        var val = baseValue;
        switch (modifier)
        {
            case Modifier.Weak:
                val /= 2f;
                break;
            case Modifier.Base:
                break;
            case Modifier.Strong:
                val *= 1.5f;
                break;
        }

        return val;
    }
}

/// <summary>
/// Possible basevalue modifiers
/// </summary>
public enum Modifier
{
    Weak,
    Base,
    Strong,
}

/// <summary>
/// Delegate for calculating modifies
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);