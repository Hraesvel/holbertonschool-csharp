# 0x05. C# - Structs, Enumerations

**Table Of Context**
- [0. They're good dogs](#0-They're-good-dogs)
- [1. Chief Puppy Officer](#1-Chief-Puppy-Officer)
- [2. A dog is the only thing on earth that loves you more than you love yourself](#2-A-dog-is-the-only-thing-on-earth-that-loves-you-more-than-you-love-yourself)
- [3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad](#3-A-dog-will-teach-you-unconditional-love-If-you-can-have-that-in-your-life,-things-won't-be-too-bad)

## Tasks


### 0. They're good dogs
File: **[0-dog/, 0-dog/0-dog.csproj, 0-dog/0-dog.cs](0-dog/, 0-dog/0-dog.csproj, 0-dog/0-dog.cs)**


```
martin@ubuntu:~/0x05-csharp-structs_enums\0-dog$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}
martin@ubuntu:~/0x05-csharp-structs_enums\0-dog$

```

```
martin@ubuntu:~/0x05-csharp-structs_enums\0-dog$ ls
bin    obj    0-dog.cs    0-dog.csproj    0-main.cs
martin@ubuntu:~/0x05-csharp-structs_enums\0-dog$ dotnet run
Score: Great
Score: 1
martin@ubuntu:~/0x05-csharp-structs_enums\0-dog$

```



*[top](#0x05-C---Structs,-Enumerations)*

---


### 1. Chief Puppy Officer
File: **[1-dog/, 1-dog/1-dog.csproj, 1-dog/1-dog.cs](1-dog/, 1-dog/1-dog.csproj, 1-dog/1-dog.cs)**


```
martin@ubuntu:~/0x05-csharp-structs_enums\1-dog$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy.name = "Poppy";
        poppy.age = 0.7f;
        poppy.owner = "Kris";
        poppy.rating = Rating.Excellent;

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
martin@ubuntu:~/0x05-csharp-structs_enums\1-dog$

```

```
martin@ubuntu:~/0x05-csharp-structs_enums\1-dog$ ls
bin    obj    1-dog.cs    1-dog.csproj    1-main.cs
martin@ubuntu:~/0x05-csharp-structs_enums\1-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
martin@ubuntu:~/0x05-csharp-structs_enums\1-dog$

```



*[top](#0x05-C---Structs,-Enumerations)*

---


### 2. A dog is the only thing on earth that loves you more than you love yourself
File: **[2-dog/, 2-dog/2-dog.csproj, 2-dog/2-dog.cs](2-dog/, 2-dog/2-dog.csproj, 2-dog/2-dog.cs)**


```
martin@ubuntu:~/0x05-csharp-structs_enums\2-dog$ cat 2-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine("My name is {0} and I am {1}. I am an {2} dog. :)", poppy.name, poppy.age, poppy.rating);
    }
}
martin@ubuntu:~/0x05-csharp-structs_enums\2-dog$

```

```
martin@ubuntu:~/0x05-csharp-structs_enums\2-dog$ ls
bin    obj    2-dog.cs    2-dog.csproj    2-main.cs
martin@ubuntu:~/0x05-csharp-structs_enums\2-dog$ dotnet run
My name is Poppy and I am 0.7. I am an Excellent dog. :)
martin@ubuntu:~/0x05-csharp-structs_enums\2-dog$

```



*[top](#0x05-C---Structs,-Enumerations)*

---


### 3. A dog will teach you unconditional love. If you can have that in your life, things won't be too bad
File: **[3-dog/, 3-dog/3-dog.csproj, 3-dog/3-dog.cs](3-dog/, 3-dog/3-dog.csproj, 3-dog/3-dog.cs)**


```
Dog Name: <name>
Age: <age>
Owner: <owner>
Rating: <rating>

```

```
martin@ubuntu:~/0x05-csharp-structs_enums\3-dog$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Dog poppy;

        poppy = new Dog("Poppy", 0.7f, "Kris", Rating.Excellent);

        Console.WriteLine(poppy.ToString());
    }
}
martin@ubuntu:~/0x05-csharp-structs_enums\3-dog$

```

```
martin@ubuntu:~/0x05-csharp-structs_enums\3-dog$ ls
bin    obj    3-dog.cs    3-dog.csproj    3-main.cs
martin@ubuntu:~/0x05-csharp-structs_enums\3-dog$ dotnet run
Dog Name: Poppy
Age: 0.7
Owner: Kris
Rating: Excellent
martin@ubuntu:~/0x05-csharp-structs_enums\3-dog$

```



*[top](#0x05-C---Structs,-Enumerations)*

---


