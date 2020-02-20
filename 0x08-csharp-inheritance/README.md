# 0x08. C# - Inheritance

**Table Of Context**
- [0. This is one of these](#0-This-is-one-of-these)
- [1. For instance](#1-For-instance)
- [2. Only subclass](#2-Only-subclass)
- [3. Type](#3-Type)
- [4. It's not a lesson in classes and inheritance without a Dog](#4-It's-not-a-lesson-in-classes-and-inheritance-without-a-Dog)
- [5. Basic shapes](#5-Basic-shapes)
- [6. Rectangle](#6-Rectangle)
- [7. Full rectangle](#7-Full-rectangle)
- [8. Square #1](#8-Square-1)
- [9. Square #2](#9-Square-2)
- [10. Liskov](#10-Liskov)

## Tasks


### 0. This is one of these
File: **[0-is/, 0-is/0-is.csproj, 0-is/0-is.cs](0-is/, 0-is/0-is.csproj, 0-is/0-is.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/0-is$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        var b = new List<int>();

        if (Obj.IsOfTypeInt(a))
            Console.WriteLine("{0} is of type int", nameof(a));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(a));

        if (Obj.IsOfTypeInt(b))
            Console.WriteLine("{0} is of type int", nameof(b));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(b));
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/0-is$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/0-is$ ls
0-is.cs  0-is.csproj  0-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/0-is$ dotnet run
a is of type int
b is NOT of type int
martin@ubuntu:~/0x08-csharp-inheritance/0-is$

```



*[top](#0x08-C---Inheritance)*

---


### 1. For instance
File: **[1-instance/, 1-instance/1-instance.csproj, 1-instance/1-instance.cs](1-instance/, 1-instance/1-instance.csproj, 1-instance/1-instance.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/1-instance$ cat 1-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numArray = new int[10];
        var num = 10;
        var aList = new List<int>();

        if (Obj.IsInstanceOfArray(numArray))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(numArray));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(numArray));

        if (Obj.IsInstanceOfArray(num))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(num));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(num));

        if (Obj.IsInstanceOfArray(aList))
            Console.WriteLine("{0} is an instance of type array or inherits from type array", nameof(aList));
        else
            Console.WriteLine("{0} is NOT an instance of type array nor inherits from type array", nameof(aList));
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/1-instance$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/1-instance$ ls
1-instance.cs  1-instance.csproj  1-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/1-instance$ dotnet run
numArray is an instance of type array or inherits from type array
num is NOT an instance of type array or inherits from type array
aList is NOT an instance of type array or inherits from type array
martin@ubuntu:~/0x08-csharp-inheritance/1-instance$

```



*[top](#0x08-C---Inheritance)*

---


### 2. Only subclass
File: **[2-subclass/, 2-subclass/2-subclass.csproj, 2-subclass/2-subclass.cs](2-subclass/, 2-subclass/2-subclass.csproj, 2-subclass/2-subclass.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/2-subclass$ cat 2-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        if (Obj.IsOnlyASubclass(typeof(Dog), typeof(Animal)))
            Console.WriteLine("Dog is a subclass of Animal");
        else
            Console.WriteLine("Dog is not a subclass of Animal");

        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Animal)))
            Console.WriteLine("Cat is a subclass of Animal");
        else
            Console.WriteLine("Cat is not a subclass of Animal");

        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Dog)))
            Console.WriteLine("Cat is a subclass of Dog");
        else
            Console.WriteLine("Cat is not a subclass of Dog");

        if (Obj.IsOnlyASubclass(typeof(Animal), typeof(Animal)))
            Console.WriteLine("Animal is a subclass of Animal");
        else
            Console.WriteLine("Animal is not a subclass of Animal");
    }
}

class Animal
{
    // Empty class
}

class Dog : Animal
{
    // Empty class
}

class Cat : Animal
{
    // Empty class
}
martin@ubuntu:~/0x08-csharp-inheritance/2-subclass$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/2-subclass$ ls
2-subclass.cs  2-subclass.csproj  2-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/2-subclass$ dotnet run
Dog is a subclass of Animal
Cat is a subclass of Animal
Cat is not a subclass of Dog
Animal is not a subclass of Animal
martin@ubuntu:~/0x08-csharp-inheritance/2-subclass$

```



*[top](#0x08-C---Inheritance)*

---


### 3. Type
File: **[3-type_get/, 3-type_get/3-type_get.csproj, 3-type_get/3-type_get.cs](3-type_get/, 3-type_get/3-type_get.csproj, 3-type_get/3-type_get.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/3-type_get$ cat 3-main.cs
using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var num = 10;
        var myList = new List<int>();

        Obj.Print(num);
        Console.WriteLine("-----------------");
        Obj.Print(myList);
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/3-type_get$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/3-type_get$ ls
3-type_get.cs  3-type_get.csproj  3-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/3-type_get$ dotnet run
Int32 Properties:
Int32 Methods:
CompareTo
CompareTo
Equals
Equals
GetHashCode
ToString
ToString
ToString
ToString
Parse
Parse
Parse
Parse
TryParse
TryParse
GetTypeCode
GetType
-----------------
List`1 Properties:
Capacity
Count
Item
List`1 Methods:
get_Capacity
set_Capacity
get_Count
get_Item
set_Item
Add
AddRange
AsReadOnly
BinarySearch
BinarySearch
BinarySearch
Clear
Contains
ConvertAll
CopyTo
CopyTo
CopyTo
Exists
Find
FindAll
FindIndex
FindIndex
FindIndex
FindLast
FindLastIndex
FindLastIndex
FindLastIndex
ForEach
GetEnumerator
GetRange
IndexOf
IndexOf
IndexOf
Insert
InsertRange
LastIndexOf
LastIndexOf
LastIndexOf
Remove
RemoveAll
RemoveAt
RemoveRange
Reverse
Reverse
Sort
Sort
Sort
Sort
ToArray
TrimExcess
TrueForAll
ToString
Equals
GetHashCode
GetType
martin@ubuntu:~/0x08-csharp-inheritance/3-type_get$

```



*[top](#0x08-C---Inheritance)*

---


### 4. It's not a lesson in classes and inheritance without a Dog
File: **[4-inherit/, 4-inherit/4-inherit.cs, 4-inherit/4-inherit.csproj](4-inherit/, 4-inherit/4-inherit.cs, 4-inherit/4-inherit.csproj)**


```
martin@ubuntu:~/0x08-csharp-inheritance/4-inherit$ cat 4-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        object obj = myDog;
        Animal anotherAnimal = myDog;

        Console.WriteLine("myAnimal is a {0}", myAnimal.GetType());
        Console.WriteLine("myDog is a {0}", myDog.GetType());
        Console.WriteLine("obj is a {0}", obj.GetType());
        Console.WriteLine("anotherAnimal is a {0}", anotherAnimal.GetType());
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/4-inherit$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/4-inherit$ ls
4-inherit.cs  4-inherit.csproj  4-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/4-inherit$ dotnet run
myAnimal is a Animal
myDog is a Dog
obj is a Dog
anotherAnimal is a Dog
martin@ubuntu:~/0x08-csharp-inheritance/4-inherit$

```



*[top](#0x08-C---Inheritance)*

---


### 5. Basic shapes
File: **[5-shape/, 5-shape/5-shape.csproj, 5-shape/5-shape.cs](5-shape/, 5-shape/5-shape.csproj, 5-shape/5-shape.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/5-shape$ cat 5-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Shape aShape = new Shape();

        try
        {
            Console.WriteLine("Area: {0}", aShape.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/5-shape$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/5-shape$ ls
5-shape.cs  5-shape.csproj  5-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/5-shape$ dotnet run
System.NotImplementedException: Area() is not implemented
...
martin@ubuntu:~/0x08-csharp-inheritance/5-shape$

```



*[top](#0x08-C---Inheritance)*

---


### 6. Rectangle
File: **[6-shape/, 6-shape/6-shape.csproj, 6-shape/6-shape.cs](6-shape/, 6-shape/6-shape.csproj, 6-shape/6-shape.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/6-shape$ cat 6-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 10;
        aRect.Height = 2;

        if (typeof(Rectangle).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Rectangle is a subclass of Shape");
        else
            Console.WriteLine("Rectangle is a NOT subclass of Shape");

        Console.WriteLine("Width: {0}", aRect.Width);
        Console.WriteLine("Height: {0}", aRect.Height);

        try
        {
            Console.WriteLine("Area: {0}", aRect.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/6-shape$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/6-shape$ ls
6-shape.cs  6-shape.csproj  6-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/6-shape$ dotnet run
Rectangle is a subclass of Shape
Width: 10
Height: 2
System.NotImplementedException: Area() is not implemented
...
martin@ubuntu:~/0x08-csharp-inheritance/6-shape$

```



*[top](#0x08-C---Inheritance)*

---


### 7. Full rectangle
File: **[7-shape/, 7-shape/7-shape.csproj, 7-shape/7-shape.cs](7-shape/, 7-shape/7-shape.csproj, 7-shape/7-shape.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/7-shape$ cat 7-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();

        aRect.Width = 7;
        aRect.Height = 4;

        Console.WriteLine("Area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/7-shape$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/7-shape$ ls
7-shape.cs  7-shape.csproj  7-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/7-shape$ dotnet run
Area: 28
[Rectangle] 7 / 4
martin@ubuntu:~/0x08-csharp-inheritance/7-shape$

```



*[top](#0x08-C---Inheritance)*

---


### 8. Square #1
File: **[8-shape/, 8-shape/8-shape.csproj, 8-shape/8-shape.cs](8-shape/, 8-shape/8-shape.csproj, 8-shape/8-shape.cs)**


```
martin@ubuntu:~/0x08-csharp-inheritance/8-shape$ cat 8-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();

        aSquare.Size = 10;

        if (typeof(Square).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Square is a subclass of Shape");
        else
            Console.WriteLine("Square is a NOT subclass of Shape");

        Console.WriteLine("Size: {0}", aSquare.Size);
    }
}
martin@ubuntu:~/0x08-csharp-inheritance/8-shape$

```

```
martin@ubuntu:~/0x08-csharp-inheritance/8-shape$ ls
8-shape.cs  8-shape.csproj  8-main.cs  bin  obj
martin@ubuntu:~/0x08-csharp-inheritance/8-shape$ dotnet run
Square is a subclass of Shape
Size: 10
martin@ubuntu:~/0x08-csharp-inheritance/8-shape$

```



*[top](#0x08-C---Inheritance)*

---


### 9. Square #2
File: **[9-shape/, 9-shape/9-shape.csproj, 9-shape/9-shape.cs](9-shape/, 9-shape/9-shape.csproj, 9-shape/9-shape.cs)**


```
martin@ubuntu:~/0x09-csharp-inheritance/9-shape$ cat 9-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 6;
        aRect.Height = 8;
        Console.WriteLine("aRect width: {0}", aRect.Width);
        Console.WriteLine("aRect height: {0}", aRect.Height);
        Console.WriteLine("aRect area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());

        Console.WriteLine("------------------");

        Square aSquare = new Square();
        aSquare.Size = 12;
        Console.WriteLine("aSquare width: {0}", aSquare.Width);
        Console.WriteLine("aSquare height: {0}", aSquare.Height);
        Console.WriteLine("aSquare area: {0}", aSquare.Area());
        Console.WriteLine(aSquare.ToString());
    }
}
martin@ubuntu:~/0x09-csharp-inheritance/9-shape$

```

```
martin@ubuntu:~/0x09-csharp-inheritance/9-shape$ ls
9-shape.cs  9-shape.csproj  9-main.cs  bin  obj
martin@ubuntu:~/0x09-csharp-inheritance/9-shape$ dotnet run
aRect width: 6
aRect height: 8
aRect area: 48
[Rectangle] 6 / 8
------------------
aSquare width: 12
aSquare height: 12
aSquare area: 144
[Square] 12 / 12
martin@ubuntu:~/0x09-csharp-inheritance/9-shape$

```



*[top](#0x08-C---Inheritance)*

---


### 10. Liskov
File: **[]()**


<pre><code>using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();

        try
        {
            aSquare.Width = 12;
            aSquare.Height = 8;

            Console.WriteLine("aSquare width: {0}", aSquare.Width);
            Console.WriteLine("aSquare height: {0}", aSquare.Height);
            Console.WriteLine("aSquare size: {0}", aSquare.Size);
            Console.WriteLine("aSquare area: {0}", aSquare.Area());
            Console.WriteLine(aSquare.ToString());
        }
        catch (Exception e)
        {            
            Console.WriteLine(e);
        }
    }
}
</code></pre>

*[top](#0x08-C---Inheritance)*

---


