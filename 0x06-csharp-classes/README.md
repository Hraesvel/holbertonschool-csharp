# 0x06. C# - Classes and Namespaces

**Table Of Context**
- [0. Braaainsss](#0-Braaainsss)
- [1. Healthy competition](#1-Healthy-competition)
- [2. Health validation](#2-Health-validation)
- [3. Zombie health](#3-Zombie-health)
- [4. Hello, my name is](#4-Hello,-my-name-is)
- [5. Printing a zombie](#5-Printing-a-zombie)

## Tasks


### 0. Braaainsss
File: **[0-enemy/, 0-enemy/0-enemy.csproj, 0-enemy/0-enemy.cs](0-enemy/, 0-enemy/0-enemy.csproj, 0-enemy/0-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/0-enemy$ cat 0-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
martin@ubuntu:~/0x06-csharp-classes/0-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/0-enemy$ ls
0-enemy.cs  0-enemy.csproj  0-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/0-enemy$ dotnet run
newObject is of type Enemies.Zombie
String representation: Enemies.Zombie
martin@ubuntu:~/0x06-csharp-classes/0-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


### 1. Healthy competition
File: **[1-enemy/, 1-enemy/1-enemy.csproj, 1-enemy/1-enemy.cs](1-enemy/, 1-enemy/1-enemy.csproj, 1-enemy/1-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/1-enemy$ cat 1-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}
martin@ubuntu:~/0x06-csharp-classes/1-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/1-enemy$ ls
1-enemy.cs  1-enemy.csproj  1-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/1-enemy$ dotnet run
newObject is of type Enemies.Zombie and has a total of 0 health
martin@ubuntu:~/0x06-csharp-classes/1-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


### 2. Health validation
File: **[2-enemy/, 2-enemy/2-enemy.csproj, 2-enemy/2-enemy.cs](2-enemy/, 2-enemy/2-enemy.csproj, 2-enemy/2-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/2-enemy$ cat 2-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
martin@ubuntu:~/0x06-csharp-classes/2-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/2-enemy$ ls
2-enemy.cs  2-enemy.csproj  2-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/2-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
Health must be greater than or equal to 0
martin@ubuntu:~/0x06-csharp-classes/2-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


### 3. Zombie health
File: **[3-enemy/, 3-enemy/3-enemy.csproj, 3-enemy/3-enemy.cs](3-enemy/, 3-enemy/3-enemy.csproj, 3-enemy/3-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/3-enemy$ cat 3-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
martin@ubuntu:~/0x06-csharp-classes/3-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/3-enemy$ ls
3-enemy.cs  3-enemy.csproj  3-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/3-enemy$ dotnet run
newObject1 is of type Enemies.Zombie and has a total of 10 health
newObject2 is of type Enemies.Zombie and has a total of 98 health
martin@ubuntu:~/0x06-csharp-classes/3-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


### 4. Hello, my name is
File: **[4-enemy/, 4-enemy/4-enemy.csproj, 4-enemy/4-enemy.cs](4-enemy/, 4-enemy/4-enemy.csproj, 4-enemy/4-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/4-enemy$ cat 4-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject1.Name, newObject1.GetType(), newObject1.GetHealth());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
martin@ubuntu:~/0x06-csharp-classes/4-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/4-enemy$ ls
4-enemy.cs  4-enemy.csproj  4-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/4-enemy$ dotnet run
Ed is of type Enemies.Zombie and has a total of 10 health
(No name) is of type Enemies.Zombie and has a total of 98 health
martin@ubuntu:~/0x06-csharp-classes/4-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


### 5. Printing a zombie
File: **[5-enemy/, 5-enemy/5-enemy.csproj, 5-enemy/5-enemy.cs](5-enemy/, 5-enemy/5-enemy.csproj, 5-enemy/5-enemy.cs)**


```
martin@ubuntu:~/0x06-csharp-classes/5-enemy$ cat 5-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed";
            Console.WriteLine(newObject1.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(98);
            Console.WriteLine(newObject2.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
martin@ubuntu:~/0x06-csharp-classes/5-enemy$

```

```
martin@ubuntu:~/0x06-csharp-classes/5-enemy$ ls
5-enemy.cs  5-enemy.csproj  5-main.cs  bin  obj
martin@ubuntu:~/0x06-csharp-classes/5-enemy$ dotnet run
Zombie Name: Ed / Total Health: 10
Zombie Name: (No name) / Total Health: 98
martin@ubuntu:~/0x06-csharp-classes/5-enemy$

```



*[top](#0x06-C---Classes-and-Namespaces)*

---


