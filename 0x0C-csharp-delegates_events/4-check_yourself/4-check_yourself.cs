using System;


/// <summary>
/// Possible basevalue modifiers
/// </summary>
public enum Modifier
{
    /// <summary>glancing</summary>
    Weak,

    /// <summary>base</summary>
    Base,

    /// <summary>critical</summary>
    Strong,
}

/// <summary>
/// Delegate for calculating modifies
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Deleagate for calculating health
/// </summary>
/// <param name="amt">amount</param>
public delegate void CalculateHealth(float amt);


/// <summary>
/// Player class
/// </summary>
public class Player
{
    private float hp;
    private float maxHp;
    private string name;
    private string status;


    /// <summary>
    /// Hp check event handler
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

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

        status = $"{this.name} is ready to go!";
        hp = this.maxHp = maxHp;
        HPCheck += CheckStatus;
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
            damage = 0f;
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
            heal = 0f;
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

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }


    /// <summary>
    /// applies damage/heal modifier to value
    /// </summary>
    /// <param name="baseValue">value to be modified</param>
    /// <param name="modifier"> enum for possible modifications</param>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            default:
                return baseValue * 1.5f;
        }
    }


    /// <summary>
    /// update player field "status"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e">args</param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp < maxHp && e.currentHp >= maxHp / 2)
            status = $"{name} is doing well!";
        else if (e.currentHp < maxHp / 2 && e.currentHp >= maxHp / 4)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0f && e.currentHp < maxHp / 2)
            status = $"{name} needs help!";
        else
            status = $"{name} is knocked out!";

        Console.WriteLine(status);
    }
}


/// <summary>
/// Event Args class
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// hp
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}