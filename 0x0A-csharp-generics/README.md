# 0x0A. C# - Generics

**Table Of Context**
- [0. Queue](#0-Queue)
- [1. Enqueue](#1-Enqueue)
- [2. Dequeue](#2-Dequeue)
- [3. Peek](#3-Peek)
- [4. Print](#4-Print)
- [5. Concatenate](#5-Concatenate)

## Tasks


### 0. Queue
File: **[0-queue/, 0-queue/0-queue.csproj, 0-queue/queue.cs](0-queue/, 0-queue/0-queue.csproj, 0-queue/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/0-queue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}
martin@ubuntu:~/0x0A-csharp-generics/0-queue$

```

```
martin@ubuntu:~/0x0A-csharp-generics/0-queue$ dotnet run
myStrQ Queue Type: System.String
myObjQ Queue Type: System.Object
martin@ubuntu:~/0x0A-csharp-generics/0-queue$

```



*[top](#0x0A-C---Generics)*

---


### 1. Enqueue
File: **[1-enqueue/, 1-enqueue/1-enqueue.csproj, 1-enqueue/queue.cs](1-enqueue/, 1-enqueue/1-enqueue.csproj, 1-enqueue/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/1-enqueue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        myStrQ.Enqueue("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        myFloatQ.Enqueue(-9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}
martin@ubuntu:~/0x0A-csharp-generics/1-enqueue$

```

```
martin@ubuntu:~/0x0A-csharp-generics/1-enqueue$ dotnet run
Number of nodes in queue: 1
Number of nodes in queue: 2
----------
Number of nodes in queue: 3
Number of nodes in queue: 4
martin@ubuntu:~/0x0A-csharp-generics/1-enqueue$

```



*[top](#0x0A-C---Generics)*

---


### 2. Dequeue
File: **[2-dequeue/, 2-dequeue/2-dequeue.csproj, 2-dequeue/queue.cs](2-dequeue/, 2-dequeue/2-dequeue.csproj, 2-dequeue/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/2-dequeue$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}
martin@ubuntu:~/0x0A-csharp-generics/2-dequeue$

```

```
martin@ubuntu:~/0x0A-csharp-generics/2-dequeue$ dotnet run
Number of nodes in queue: 2
First value: 100
Number of nodes in queue: 1
----------
Number of nodes in queue: 1
First value: 9.8
Number of nodes in queue: 0
Queue is empty
First value: 0
martin@ubuntu:~/0x0A-csharp-generics/2-dequeue$

```



*[top](#0x0A-C---Generics)*

---


### 3. Peek
File: **[3-peek/, 3-peek/3-peek.csproj, 3-peek/queue.cs](3-peek/, 3-peek/3-peek.csproj, 3-peek/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/3-peek$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        myIntQ.Enqueue(102);

        Console.WriteLine("First value: " + myIntQ.Peek());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        Console.WriteLine("First value: " + myCharQ.Peek());
    }
}
martin@ubuntu:~/0x0A-csharp-generics/3-peek$

```

```
martin@ubuntu:~/0x0A-csharp-generics/3-peek$
First value: 100
Number of nodes in queue: 3
----------
Queue is empty
First value:
martin@ubuntu:~/0x0A-csharp-generics/3-peek$

```



*[top](#0x0A-C---Generics)*

---


### 4. Print
File: **[4-print/, 4-print/4-print.csproj, 4-print/queue.cs](4-print/, 4-print/4-print.csproj, 4-print/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/4-print$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        myStrQ.Print();

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Print();
    }
}
martin@ubuntu:~/0x0A-csharp-generics/4-print$

```

```
martin@ubuntu:~/0x0A-csharp-generics/4-print$
hello
holberton
school
----------
Queue is empty
martin@ubuntu:~/0x0A-csharp-generics/4-print$

```



*[top](#0x0A-C---Generics)*

---


### 5. Concatenate
File: **[5-concatenate/, 5-concatenate/5-concatenate.csproj, 5-concatenate/queue.cs](5-concatenate/, 5-concatenate/5-concatenate.csproj, 5-concatenate/queue.cs)**


```
martin@ubuntu:~/0x0A-csharp-generics/5-concatenate$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("hello");
        myStrQ.Enqueue("holberton");
        myStrQ.Enqueue("school");

        Console.WriteLine(myStrQ.Concatenate());

        Console.WriteLine("----------");

        Queue<int> myIntQ = new Queue<int>();
        myIntQ.Concatenate();

        Console.WriteLine("----------");

        Queue<char> myCharQ = new Queue<char>();
        myCharQ.Enqueue('a');
        myCharQ.Enqueue('b');
        myCharQ.Enqueue('c');
        Console.WriteLine(myCharQ.Concatenate());
    }
}
martin@ubuntu:~/0x0A-csharp-generics/5-concatenate$

```

```
martin@ubuntu:~/0x0A-csharp-generics/5-concatenate$
hello holberton school
----------
Queue is empty
----------
abc
martin@ubuntu:~/0x0A-csharp-generics/5-concatenate$

```



*[top](#0x0A-C---Generics)*

---


