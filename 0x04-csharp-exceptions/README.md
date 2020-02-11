# 0x04. C# - Exceptions

**Table Of Context**
- [0. Safe list printing](#0-Safe-list-printing)
- [1. Integer division](#1-Integer-division)
- [2. Divide lists](#2-Divide-lists)
- [3. Throw exception](#3-Throw-exception)
- [4. Throw exception with message](#4-Throw-exception-with-message)

## Tasks


### 0. Safe list printing
File: **[0-safe_list_print/, 0-safe_list_print/0-safe_list_print.csproj, 0-safe_list_print/0-safe_list_print.cs ](0-safe_list_print/, 0-safe_list_print/0-safe_list_print.csproj, 0-safe_list_print/0-safe_list_print.cs )**


```
martin@ubuntu:~/0x04/0-safe_list_print$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}
martin@ubuntu:~/0x04/0-safe_list_print$

```

```
martin@ubuntu:~/0x04/0-safe_list_print$ ls
0-main.cs  0-safe_list_print.cs  0-safe_list_print.csproj  bin  obj
martin@ubuntu:~/0x04/0-safe_list_print$ dotnet run
1
2
3
4
5
Number of integers printed: 5

1
2
3
Number of integers printed: 3

1
2
3
4
5
Number of integers printed: 5
martin@ubuntu:~/0x04/0-safe_list_print$

```



*[top](#0x04-C---Exceptions)*

---


### 1. Integer division
File: **[1-divide_print/, 1-divide_print/1-divide_print.csproj, 1-divide_print/1-divide_print.cs](1-divide_print/, 1-divide_print/1-divide_print.csproj, 1-divide_print/1-divide_print.cs)**


```
martin@ubuntu:~/0x04/1-divide_print$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        a = 4;
        b = 3;
        Int.divide(a, b);
        Console.WriteLine();

        a = 9;
        b = 0;
        Int.divide(a, b);
    }
}
martin@ubuntu:~/0x04/1-divide_print$

```

```
martin@ubuntu:~/0x04/1-divide_print$ ls
1-main.cs  1-divide_print.cs  1-divide_print.csproj  bin  obj
martin@ubuntu:~/0x04/1-divide_print$ dotnet run
4 / 3 = 1

Cannot divide by zero
9 / 0 = 0
martin@ubuntu:~/0x04/1-divide_print$

```



*[top](#0x04-C---Exceptions)*

---


### 2. Divide lists
File: **[2-divide_lists/, 2-divide_lists/2-divide_lists.csproj, 2-divide_lists/2-divide_lists.cs](2-divide_lists/, 2-divide_lists/2-divide_lists.csproj, 2-divide_lists/2-divide_lists.cs)**


```
martin@ubuntu:~/0x04/2-divide_lists$ cat 2-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() {1, 20, 16, 15, 54};
        List<int> list2 = new List<int>() {1, 0, 2, 3};
        List<int> result;

        result = List.Divide(list1, list2, 5);

        foreach (int i in result)
            Console.WriteLine(i);
    }
}
martin@ubuntu:~/0x04/2-divide_lists$

```

```
martin@ubuntu:~/0x04/2-divide_lists$ ls
2-main.cs  2-divide_lists.cs  2-divide_lists.csproj  bin  obj
martin@ubuntu:~/0x04/2-divide_lists$ dotnet run
Cannot divide by zero
Out of range
1
0
8
5
martin@ubuntu:~/0x04/2-divide_lists$

```



*[top](#0x04-C---Exceptions)*

---


### 3. Throw exception
File: **[3-throw_exception/, 3-throw_exception/3-throw_exception.csproj, 3-throw_exception/3-throw_exception.cs](3-throw_exception/, 3-throw_exception/3-throw_exception.csproj, 3-throw_exception/3-throw_exception.cs)**


```
martin@ubuntu:~/0x04/3-throw_exception$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.Throw();
        }
        catch (Exception)
        {
            Console.WriteLine("Exception raised");
        }
    }
}
martin@ubuntu:~/0x04/3-throw_exception$

```

```
martin@ubuntu:~/0x04/3-throw_exception$ ls
3-main.cs  3-throw_exception.cs  3-throw_exception.csproj  bin  obj
martin@ubuntu:~/0x04/3-throw_exception$ dotnet run
Exception raised
martin@ubuntu:~/0x04/3-throw_exception$

```



*[top](#0x04-C---Exceptions)*

---


### 4. Throw exception with message
File: **[4-throw_exception_msg/, 4-throw_exception_msg/4-throw_exception_msg.csproj, 4-throw_exception_msg/4-throw_exception_msg.cs](4-throw_exception_msg/, 4-throw_exception_msg/4-throw_exception_msg.csproj, 4-throw_exception_msg/4-throw_exception_msg.cs)**


```
martin@ubuntu:~/0x04/4-throw_exception_msg$ cat 4-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Except.ThrowMsg("C is fun");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
martin@ubuntu:~/0x04/4-throw_exception_msg$

```

```
martin@ubuntu:~/0x04/4-throw_exception_msg$ ls
4-main.cs  4-throw_exception_msg.cs  4-throw_exception_msg.csproj  bin  obj
martin@ubuntu:~/0x04/4-throw_exception_msg$ dotnet run
C is fun
martin@ubuntu:~/0x04/4-throw_exception_msg$

```



*[top](#0x04-C---Exceptions)*

---


