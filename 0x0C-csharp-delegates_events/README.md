# 0x0C. C# - Delegates, Events

**Table Of Context**
- [0. Universal health](#0-Universal-health)
- [1. Damage delegation](#1-Damage-delegation)
- [2. Validation](#2-Validation)
- [3. Modified behavior](#3-Modified-behavior)
- [4. Check yourself](#4-Check-yourself)
- [5. Eventful](#5-Eventful)

## Tasks


### 0. Universal health
File: **[0-universal_health/, 0-universal_health/0-universal_health.csproj](0-universal_health/, 0-universal_health/0-universal_health.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/0-universal_health$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");

        player1.PrintHealth();
        player2.PrintHealth();
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/0-universal_health$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/0-universal_health$ dotnet run
Electric Mouse has 500 / 500 health
Water Turtle has 100 / 100 health
martin@ubuntu:~/0x0C-csharp-delegates_events/0-universal_health$

```



*[top](#0x0C-C---Delegates,-Events)*

---


### 1. Damage delegation
File: **[1-damage_delegation/, 1-damage_delegation/1-damage_delegation.csproj](1-damage_delegation/, 1-damage_delegation/1-damage_delegation.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/1-delegate_delegation$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.TakeDamage(25f);

        player.HealDamage(10f);
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/1-delegate_delegation$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/1-delegate_delegation$ dotnet run
Electric Mouse takes 25 damage!
Electric Mouse heals 10 HP!
martin@ubuntu:~/0x0C-csharp-delegates_events/1-delegate_delegation$

```



*[top](#0x0C-C---Delegates,-Events)*

---


### 2. Validation
File: **[2-validation/, 2-validation/2-validation.csproj](2-validation/, 2-validation/2-validation.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/2-validation$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");

        player.PrintHealth();

        player.TakeDamage(50f);

        player.PrintHealth();

        player.HealDamage(49f);

        player.PrintHealth();
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/2-validation$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/2-validation$ dotnet run
Electric Mouse has 100 / 100 health
Electric Mouse takes 50 damage!
Electric Mouse has 50 / 100 health
Electric Mouse heals 49 HP!
Electric Mouse has 99 / 100 health
martin@ubuntu:~/0x0C-csharp-delegates_events/2-validation$

```



*[top](#0x0C-C---Delegates,-Events)*

---


### 3. Modified behavior
File: **[3-modified_behavior/, 3-modified_behavior/3-modified_behavior.csproj](3-modified_behavior/, 3-modified_behavior/3-modified_behavior.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/3-modified_behavior$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();

        player.TakeDamage(mod(50f, Modifier.Weak));

        player.PrintHealth();

        player.HealDamage(mod(10f, Modifier.Strong));

        player.PrintHealth();
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/3-modified_behavior$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/3-modified_behavior$ dotnet run
Electric Mouse has 100 / 100 health
Electric Mouse takes 25 damage!
Electric Mouse has 75 / 100 health
Electric Mouse heals 15 HP!
Electric Mouse has 90 / 100 health
martin@ubuntu:~/0x0C-csharp-delegates_events/3-modified_behavior$

```



*[top](#0x0C-C---Delegates,-Events)*

---


### 4. Check yourself
File: **[4-check_yourself/, 4-check_yourself/4-check_yourself.csproj](4-check_yourself/, 4-check_yourself/4-check_yourself.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/4-check_yourself$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(50f, Modifier.Base));
        player.PrintHealth();
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/4-check_yourself$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/4-check_yourself$ dotnet run
Electric Mouse has 100 / 100 health

Electric Mouse takes 75 damage!
Electric Mouse isn't doing too great...
Electric Mouse has 25 / 100 health

Electric Mouse heals 25 HP!
Electric Mouse is doing well!
Electric Mouse has 50 / 100 health

Electric Mouse takes 50 damage!
Electric Mouse is knocked out!
Electric Mouse has 0 / 100 health
martin@ubuntu:~/0x0C-csharp-delegates_events/4-check_yourself$

```



*[top](#0x0C-C---Delegates,-Events)*

---


### 5. Eventful
File: **[5-eventful/, 5-eventful/5-eventful.csproj](5-eventful/, 5-eventful/5-eventful.csproj)**


```
martin@ubuntu:~/0x0C-csharp-delegates_events/5-eventful$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Electric Mouse");
        CalculateModifier mod = new CalculateModifier(player.ApplyModifier);

        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(75f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.HealDamage(mod(25f, Modifier.Base));
        player.PrintHealth();
        Console.WriteLine();

        player.TakeDamage(mod(50f, Modifier.Base));
        player.PrintHealth();
    }
}
martin@ubuntu:~/0x0C-csharp-delegates_events/5-eventful$

```

```
martin@ubuntu:~/0x0C-csharp-delegates_events/5-eventful$ dotnet run
Electric Mouse has 100 / 100 health

Electric Mouse takes 75 damage!
Electric Mouse isn't doing too great...
Health is low!
Electric Mouse has 25 / 100 health

Electric Mouse heals 25 HP!
Electric Mouse is doing well!
Electric Mouse has 50 / 100 health

Electric Mouse takes 50 damage!
Electric Mouse is knocked out!
Health has reached zero!
Electric Mouse has 0 / 100 health
martin@ubuntu:~/0x0C-csharp-delegates_events/5-eventful$

```



*[top](#0x0C-C---Delegates,-Events)*

---


