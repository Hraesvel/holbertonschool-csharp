# 0x0B. C# - Interfaces

**Table Of Context**
- [0. Abstract thinking](#0-Abstract-thinking)
- [1. User interface](#1-User-interface)
- [2. Escape room](#2-Escape-room)
- [3. Interior decorating](#3-Interior-decorating)
- [4. Key collecting](#4-Key-collecting)
- [5. Iterate and act](#5-Iterate-and-act)
- [6. Better iterating and acting](#6-Better-iterating-and-acting)

## Tasks


### 0. Abstract thinking
File: **[0-abstract_thinking/, 0-abstract_thinking/0-abstract_thinking.csproj, 0-abstract_thinking/0-abstract_thinking.cs](0-abstract_thinking/, 0-abstract_thinking/0-abstract_thinking.csproj, 0-abstract_thinking/0-abstract_thinking.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/0-abstract_thinking$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        SoftwareEngineer engineer = new SoftwareEngineer();

        engineer.name = "Betty";

        Console.WriteLine(engineer.ToString());
    }
}

class SoftwareEngineer : Base
{
    // Empty class
}
martin@ubuntu:~/0x0B-csharp-interfaces/0-abstract_thinking$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/0-abstract_thinking$ dotnet run
Betty is a SoftwareEngineer
martin@ubuntu:~/0x0B-csharp-interfaces/0-abstract_thinking$

```



*[top](#0x0B-C---Interfaces)*

---


### 1. User interface
File: **[1-user_interface/, 1-user_interface/1-user_interface.csproj, 1-user_interface/1-user_interface.cs](1-user_interface/, 1-user_interface/1-user_interface.csproj, 1-user_interface/1-user_interface.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/1-user_interface$ cat 0-main.cs
using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        TestObject item = new TestObject();
        Type type = item.GetType();

        Console.WriteLine("Type: " + type);

        Console.WriteLine("Properties:");
        foreach (PropertyInfo info in type.GetProperties())
            Console.WriteLine(info.Name);

        Console.WriteLine("Methods:");
        foreach (MethodInfo info in type.GetMethods())
            Console.WriteLine(info.Name);
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/1-user_interface$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/1-user_interface$ dotnet run
Type: TestObject
Properties:
durability
isCollected
Methods:
get_durability
set_durability
get_isCollected
set_isCollected
Interact
Break
Collect
ToString
Equals
GetHashCode
GetType
martin@ubuntu:~/0x0B-csharp-interfaces/1-user_interface$

```



*[top](#0x0B-C---Interfaces)*

---


### 2. Escape room
File: **[2-doors/, 2-doors/2-doors.csproj, 2-doors/2-doors.cs](2-doors/, 2-doors/2-doors.csproj, 2-doors/2-doors.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/2-doors$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");

        Console.WriteLine(frontDoor.ToString());

        frontDoor.Interact();
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/2-doors$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/2-doors$ dotnet run
Front Door is a Door
You try to open the Front Door. It's locked.
martin@ubuntu:~/0x0B-csharp-interfaces/2-doors$

```



*[top](#0x0B-C---Interfaces)*

---


### 3. Interior decorating
File: **[3-decorations/, 3-decorations/3-decorations.csproj, 3-decorations/3-decorations.cs](3-decorations/, 3-decorations/3-decorations.csproj, 3-decorations/3-decorations.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/3-decorations$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 2);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/3-decorations$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/3-decorations$ dotnet run
Coffee Mug is a Decoration
You look at the Coffee Mug. Not much to see here.
You hit the Coffee Mug. It cracks.
You smash the Coffee Mug. What a mess.
The Coffee Mug has been broken.
martin@ubuntu:~/0x0B-csharp-interfaces/3-decorations$

```



*[top](#0x0B-C---Interfaces)*

---


### 4. Key collecting
File: **[4-keys/, 4-keys/4-keys.csproj, 4-keys/4-keys.cs](4-keys/, 4-keys/4-keys.csproj, 4-keys/4-keys.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/4-keys$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Key carKey = new Key("Car Key");

        Console.WriteLine(carKey.ToString());

        carKey.Collect();
        carKey.Collect();
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/4-keys$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/4-keys$ dotnet run
Car Key is a Key
You pick up the Car Key.
You have already picked up the Car Key.
martin@ubuntu:~/0x0B-csharp-interfaces/4-keys$

```



*[top](#0x0B-C---Interfaces)*

---


### 5. Iterate and act
File: **[5-iterate_act/, 5-iterate_act/5-iterate_act.csproj, 5-iterate_act/5-iterate_act.cs](5-iterate_act/, 5-iterate_act/5-iterate_act.csproj, 5-iterate_act/5-iterate_act.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/5-iterate_act$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Door frontDoor = new Door("Front Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 2, true);
        Key carKey = new Key("Car Key");

        List<Base> allObjects = new List<Base>();

        allObjects.Add(frontDoor);
        allObjects.Add(photo);
        allObjects.Add(antiqueVase);
        allObjects.Add(carKey);

        RoomObjects.IterateAction(allObjects, typeof(IInteractive));
        RoomObjects.IterateAction(allObjects, typeof(IBreakable));
        RoomObjects.IterateAction(allObjects, typeof(ICollectable));
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/5-iterate_act$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/5-iterate_act$ dotnet run
You try to open the Front Door. It's locked.
You look at the Awkward Family Portrait. Not much to see here.
You look at the Antique Vase. There's a key inside.
You smash the Awkward Family Portrait. What a mess.
You hit the Antique Vase. It cracks.
You pick up the Car Key.
martin@ubuntu:~/0x0B-csharp-interfaces/5-iterate_act$

```



*[top](#0x0B-C---Interfaces)*

---


### 6. Better iterating and acting
File: **[6-generic_iteration/, 6-generic_iteration/6-generic_iteration.csproj, 6-generic_iteration/6-generic_iteration.cs](6-generic_iteration/, 6-generic_iteration/6-generic_iteration.csproj, 6-generic_iteration/6-generic_iteration.cs)**


```
martin@ubuntu:~/0x0B-csharp-interfaces/6-generic_iteration$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Door sideDoor = new Door("Side Door");
        Decoration photo = new Decoration("Awkward Family Portrait");
        Decoration antiqueVase = new Decoration("Antique Vase", 5, true);

        Objs<Decoration> decorations = new Objs<Decoration>();

        decorations.Add(photo);
        decorations.Add(antiqueVase);

        foreach (Decoration deco in decorations)
        {
            Console.WriteLine(deco);
            while (deco.durability > 0)
                deco.Break();
        }

        Console.WriteLine("------------");

        Objs<IInteractive> interactables = new Objs<IInteractive>();

        interactables.Add(sideDoor);
        interactables.Add(photo);
        interactables.Add(antiqueVase);

        foreach (IInteractive obj in interactables)
        {
            Console.WriteLine(obj);
            obj.Interact();
        }
    }
}
martin@ubuntu:~/0x0B-csharp-interfaces/6-generic_iteration$

```

```
martin@ubuntu:~/0x0B-csharp-interfaces/6-generic_iteration$ dotnet run
Awkward Family Portrait is a Decoration
You smash the Awkward Family Portrait. What a mess.
Antique Vase is a Decoration
You hit the Antique Vase. It cracks.
You hit the Antique Vase. It cracks.
You hit the Antique Vase. It cracks.
You hit the Antique Vase. It cracks.
You smash the Antique Vase. What a mess.
------------
Side Door is a Door
You try to open the Side Door. It's locked.
Awkward Family Portrait is a Decoration
The Awkward Family Portrait has been broken.
Antique Vase is a Decoration
The Antique Vase has been broken.
martin@ubuntu:~/0x0B-csharp-interfaces/6-generic_iteration$

```



*[top](#0x0B-C---Interfaces)*

---


