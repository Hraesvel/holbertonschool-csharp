# 0x03. C# - Data Structures: HashSet, Stack, Queue, LinkedList

**Table Of Context**
- [0. Unique addition](#0-Unique-addition)
- [1. Present in both](#1-Present-in-both)
- [2. Only differents](#2-Only-differents)
- [3. Full stack](#3-Full-stack)
- [4. Queue it up](#4-Queue-it-up)
- [5. Print a LinkedList](#5-Print-a-LinkedList)
- [6. LinkedList length](#6-LinkedList-length)
- [7. Add node to the beginning](#7-Add-node-to-the-beginning)
- [8. Find value](#8-Find-value)
- [9. Pop](#9-Pop)
- [10. Get node at index](#10-Get-node-at-index)
- [11. LinkedList sum](#11-LinkedList-sum)
- [12. Insert at index](#12-Insert-at-index)
- [13. Delete at index](#13-Delete-at-index)

## Tasks


### 0. Unique addition
File: **[0-unique_add/, 0-unique_add/0-unique_add.csproj, 0-unique_add/0-unique_add.cs](0-unique_add/, 0-unique_add/0-unique_add.csproj, 0-unique_add/0-unique_add.cs)**


```
martin@ubuntu:~/0x03/0-unique_add$ cat 0-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 8};
        List<int> myList2 = new List<int>() {98, 98, -14, 972, 0, -42, -972};

        Console.WriteLine(List.Sum(myList1));
        Console.WriteLine(List.Sum(myList2));
    }
}
martin@ubuntu:~/0x03/0-unique_add$

```

```
martin@ubuntu:~/0x03/0-unique_add$ ls
0-main.cs  0-unique_add.cs  0-unique_add.csproj  bin  obj
martin@ubuntu:~/0x03/0-unique_add$ dotnet run
36
42
martin@ubuntu:~/0x03/0-unique_add$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 1. Present in both
File: **[1-common_elements/, 1-common_elements/1-common_elements.csproj, 1-common_elements/1-common_elements.cs](1-common_elements/, 1-common_elements/1-common_elements.csproj, 1-common_elements/1-common_elements.cs)**


```
martin@ubuntu:~/0x03/1-common_elements$ cat 1-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> newList = new List<int>();

        newList = List.CommonElements(myList1, myList2);

        foreach (int i in newList)
            Console.WriteLine(i);
    }
}
martin@ubuntu:~/0x03/1-common_elements$

```

```
martin@ubuntu:~/0x03/1-common_elements$ ls
1-common_elements.cs  1-common_elements.csproj  1-main.cs  bin  obj
martin@ubuntu:~/0x03/1-common_elements$ dotnet run
2
4
6
martin@ubuntu:~/0x03/1-common_elements$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 2. Only differents
File: **[2-different_elements/, 2-different_elements/2-different_elements.csproj, 2-different_elements/2-different_elements.cs](2-different_elements/, 2-different_elements/2-different_elements.csproj, 2-different_elements/2-different_elements.cs)**


```
martin@ubuntu:~/0x03/2-different_elements$ cat 2-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
    }
}
martin@ubuntu:~/0x03/2-different_elements$

```

```
martin@ubuntu:~/0x03/2-different_elements$ ls
2-different_elements.cs  2-different_elements.csproj  2-main.cs  bin  obj
martin@ubuntu:~/0x03/2-different_elements$ dotnet run
0
1
3
5
7
8
martin@ubuntu:~/0x03/2-different_elements$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 3. Full stack
File: **[3-stack_push_pop/, 3-stack_push_pop/3-stack_push_pop.csproj, 3-stack_push_pop/3-stack_push_pop.cs](3-stack_push_pop/, 3-stack_push_pop/3-stack_push_pop.csproj, 3-stack_push_pop/3-stack_push_pop.cs)**


```
martin@ubuntu:~/0x03/3-stack_push_pop$ cat 3-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}
martin@ubuntu:~/0x03/3-stack_push_pop$

```

```
martin@ubuntu:~/0x03/3-stack_push_pop$ ls
3-main.cs  3-stack_push_pop.cs  3-stack_push_pop.csproj  bin  obj
martin@ubuntu:~/0x03/3-stack_push_pop$ dotnet run
Ruby
React
Python
Javascript
HTML
C
------
Number of items: 6
Top item: Ruby
Stack contains "Javascript": True
------
C#
HTML
C
martin@ubuntu:~/0x03/3-stack_push_pop$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 4. Queue it up
File: **[4-queue_enqueue_dequeue](4-queue_enqueue_dequeue)**


```
martin@ubuntu:~/0x03/4-queue_enqueue_dequeue$ cat 4-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("C");
        aQueue.Enqueue("HTML");
        aQueue.Enqueue("Javascript");
        aQueue.Enqueue("Python");
        aQueue.Enqueue("React");
        aQueue.Enqueue("Ruby");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}
martin@ubuntu:~/0x03/4-queue_enqueue_dequeue$

```

```
martin@ubuntu:~/0x03/4-queue_enqueue_dequeue$ ls
4-main.cs  4-queue_enqueue_dequeue.cs  4-queue_enqueue_dequeue.csproj  bin  obj
martin@ubuntu:~/0x03/4-queue_enqueue_dequeue$ dotnet run
C
HTML
Javascript
Python
React
Ruby
------
Number of items: 6
First item: C
Queue contains "Javascript": True
------
Python
React
Ruby
C#
martin@ubuntu:~/0x03/4-queue_enqueue_dequeue$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 5. Print a LinkedList
File: **[5-print_linkedlist/, 5-print_linkedlist/5-print_linkedlist.csproj, 5-print_linkedlist/5-print_linkedlist.cs](5-print_linkedlist/, 5-print_linkedlist/5-print_linkedlist.csproj, 5-print_linkedlist/5-print_linkedlist.cs)**


```
martin@ubuntu:~/0x03/5-print_linkedlist$ cat 5-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size;

        size = 8;

        llist = LList.CreatePrint(size);
        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
}
martin@ubuntu:~/0x03/5-print_linkedlist$

```

```
martin@ubuntu:~/0x03/5-print_linkedlist$ ls
5-main.cs  5-print_linkedlist.cs  5-print_linkedlist.csproj  bin  obj
martin@ubuntu:~/0x03/5-print_linkedlist$ dotnet run
0
1
2
3
4
5
6
7
-------------
Linked List Length: 8
martin@ubuntu:~/0x03/5-print_linkedlist$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 6. LinkedList length
File: **[6-linkedlist_length/, 6-linkedlist_length/6-linkedlist_length.csproj, 6-linkedlist_length/6-linkedlist_length.cs](6-linkedlist_length/, 6-linkedlist_length/6-linkedlist_length.csproj, 6-linkedlist_length/6-linkedlist_length.cs)**


```
martin@ubuntu:~/0x03/6-linkedlist_length$ cat 6-main.cs
using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(972);
        myLList.AddLast(0);
        myLList.AddLast(8);
        myLList.AddLast(98);
        myLList.AddLast(-4);
        myLList.AddLast(8);

        Console.WriteLine(LList.Length(myLList));
    }
}
martin@ubuntu:~/0x03/6-linkedlist_length$

```

```
martin@ubuntu:~/0x03/6-linkedlist_length$ ls
6-linkedlist_length.cs  6-linkedlist_length.csproj  6-main.cs  bin  obj
martin@ubuntu:~/0x03/6-linkedlist_length$ dotnet run
6
martin@ubuntu:~/0x03/6-linkedlist_length$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 7. Add node to the beginning
File: **[7-linkedlist_add/, 7-linkedlist_add/7-linkedlist_add.csproj, 7-linkedlist_add/7-linkedlist_add.cs](7-linkedlist_add/, 7-linkedlist_add/7-linkedlist_add.csproj, 7-linkedlist_add/7-linkedlist_add.cs)**


```
martin@ubuntu:~/0x03/7-linkedlist_add$ cat 7-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(2);
        myLList.AddLast(3);
        myLList.AddLast(4);
        myLList.AddLast(5);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();

        LList.Add(myLList, 0);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
martin@ubuntu:~/0x03/7-linkedlist_add$

```

```
martin@ubuntu:~/0x03/7-linkedlist_add$ ls
7-linkedlist_add.cs  7-linkedlist_add.csproj  7-main.cs  bin  obj
martin@ubuntu:~/0x03/7-linkedlist_add$ dotnet run
1 2 3 4 5
0 1 2 3 4 5
martin@ubuntu:~/0x03/7-linkedlist_add$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 8. Find value
File: **[8-linkedlist_find/, 8-linkedlist_find/8-linkedlist_find.csproj, 8-linkedlist_find/8-linkedlist_find.cs](8-linkedlist_find/, 8-linkedlist_find/8-linkedlist_find.csproj, 8-linkedlist_find/8-linkedlist_find.cs)**


```
martin@ubuntu:~/0x03/8-linkedlist_find$ cat 8-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 16));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 1));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, -10));
    }
}
martin@ubuntu:~/0x03/8-linkedlist_find$

```

```
martin@ubuntu:~/0x03/8-linkedlist_find$ ls
8-linkedlist_find.cs  8-linkedlist_find.csproj  8-main.cs  bin  obj
martin@ubuntu:~/0x03/8-linkedlist_find$ dotnet run
Node Position: 3
Node Position: 0
Node Position: -1
martin@ubuntu:~/0x03/8-linkedlist_find$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 9. Pop
File: **[9-linkedlist_pop/, 9-linkedlist_pop/9-linkedlist_pop.csproj, 9-linkedlist_pop/9-linkedlist_pop.cs](9-linkedlist_pop/, 9-linkedlist_pop/9-linkedlist_pop.csproj, 9-linkedlist_pop/9-linkedlist_pop.cs)**


```
martin@ubuntu:~/0x03/9-linkedlist_pop$ cat 9-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }
}
martin@ubuntu:~/0x03/9-linkedlist_pop$

```

```
martin@ubuntu:~/0x03/9-linkedlist_pop$ ls
9-linkedlist_pop.cs  9-linkedlist_pop.csproj  9-main.cs  bin  obj
martin@ubuntu:~/0x03/9-linkedlist_pop$ dotnet run
11
martin@ubuntu:~/0x03/9-linkedlist_pop$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 10. Get node at index
File: **[10-linkedlist_get_node/, 10-linkedlist_get_node/10-linkedlist_get_node.csproj, 10-linkedlist_get_node/10-linkedlist_get_node.cs](10-linkedlist_get_node/, 10-linkedlist_get_node/10-linkedlist_get_node.csproj, 10-linkedlist_get_node/10-linkedlist_get_node.cs)**


```
martin@ubuntu:~/0x03/10-linkedlist_get_node$ cat 10-main.cs
using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(91);
        myLList.AddLast(-22);
        myLList.AddLast(13);
        myLList.AddLast(14);
        myLList.AddLast(-54);
        myLList.AddLast(66);
        myLList.AddLast(37);
        myLList.AddLast(-8);

        Console.WriteLine(LList.GetNode(myLList, 5));
    }
}
martin@ubuntu:~/0x03/10-linkedlist_get_node$

```

```
martin@ubuntu:~/0x03/10-linkedlist_get_node$ ls
10-linkedlist_get_node.cs  10-linkedlist_get_node.csproj  10-main.cs  bin  obj
martin@ubuntu:~/0x03/10-linkedlist_get_node$ dotnet run
66
martin@ubuntu:~/0x03/10-linkedlist_get_node$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 11. LinkedList sum
File: **[11-linkedlist_sum/, 11-linkedlist_sum/11-linkedlist_sum.csproj, 11-linkedlist_sum/11-linkedlist_sum.cs](11-linkedlist_sum/, 11-linkedlist_sum/11-linkedlist_sum.csproj, 11-linkedlist_sum/11-linkedlist_sum.cs)**


```
martin@ubuntu:~/0x03/11-linkedlist_sum$ cat 11-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(21);
        myLList.AddLast(9);
        myLList.AddLast(-8);
        myLList.AddLast(54);
        myLList.AddLast(23);
        myLList.AddLast(-6);
        myLList.AddLast(5);

        Console.WriteLine(LList.Sum(myLList));
    }
}
martin@ubuntu:~/0x03/11-linkedlist_sum$

```

```
martin@ubuntu:~/0x03/11-linkedlist_sum$ ls
11-linkedlist_sum.cs  11-linkedlist_sum.csproj  11-main.cs  bin  obj
martin@ubuntu:~/0x03/11-linkedlist_sum$ dotnet run
98
martin@ubuntu:~/0x03/11-linkedlist_sum$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 12. Insert at index
File: **[12-linkedlist_insert/, 12-linkedlist_insert/12-linkedlist_insert.csproj, 12-linkedlist_insert/12-linkedlist_insert.cs](12-linkedlist_insert/, 12-linkedlist_insert/12-linkedlist_insert.csproj, 12-linkedlist_insert/12-linkedlist_insert.cs)**


```
martin@ubuntu:~/0x03/12-linkedlist_insert$ cat 12-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 21);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
martin@ubuntu:~/0x03/12-linkedlist_insert$

```

```
martin@ubuntu:~/0x03/12-linkedlist_insert$ ls
12-linkedlist_insert.cs  12-linkedlist_insert.csproj  12-main.cs  bin  obj
martin@ubuntu:~/0x03/12-linkedlist_insert$ dotnet run
1
4
9
16
25
36
49
------------------
1
4
9
16
21
25
36
49
martin@ubuntu:~/0x03/12-linkedlist_insert$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


### 13. Delete at index
File: **[13-linkedlist_delete/, 13-linkedlist_delete/13-linkedlist_delete.csproj, 13-linkedlist_delete/13-linkedlist_delete.cs](13-linkedlist_delete/, 13-linkedlist_delete/13-linkedlist_delete.csproj, 13-linkedlist_delete/13-linkedlist_delete.cs)**


```
martin@ubuntu:~/0x03/13-linkedlist_delete$ cat 13-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("-------------------");
        LList.Delete(myLList, 5);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
martin@ubuntu:~/0x03/13-linkedlist_delete$

```

```
martin@ubuntu:~/0x03/13-linkedlist_delete$ ls
13-linkedlist_delete.cs  13-linkedlist_delete.csproj  13-main.cs  bin  obj
martin@ubuntu:~/0x03/13-linkedlist_delete$ dotnet run
1
4
9
16
25
36
49
-------------------
1
4
9
16
25
49
martin@ubuntu:~/0x03/13-linkedlist_delete$

```



*[top](#0x03-C---Data-Structures:-HashSet,-Stack,-Queue,-LinkedList)*

---


