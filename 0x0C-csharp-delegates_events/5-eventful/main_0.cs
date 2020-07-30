using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("A Bunch of Angry Eggs", 500f);
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(1f, Modifier.Base));
        player.PrintHealth();
    }
}