2# 0x02. C# - Data Structures: Arrays, Lists, Dictionaries

**Table Of Context**
- [0. Print an array of integers](#0-Print-an-array-of-integers)
- [1. Access an element in an array](#1-Access-an-element-in-an-array)
- [2. Replace element](#2-Replace-element)
- [3. Print an array of integers... in reverse!](#3-Print-an-array-of-integers-in-reverse!)
- [4. Print a list of integers](#4-Print-a-list-of-integers)
- [5. Find the max](#5-Find-the-max)
- [6. Only by 2](#6-Only-by-2)
- [7. Delete at](#7-Delete-at)
- [8. Number of keys](#8-Number-of-keys)
- [9. Update dictionary](#9-Update-dictionary)
- [10. Delete from dictionary](#10-Delete-from-dictionary)
- [11. Multiply by 2](#11-Multiply-by-2)
- [12. Print sorted dictionary](#12-Print-sorted-dictionary)
- [13. Best score](#13-Best-score)
- [14. Rectangular array](#14-Rectangular-array)
- [15. Matrix squared](#15-Matrix-squared)

## Tasks


### 0. Print an array of integers
File: **[0-print_array/, 0-print_array/0-print_array.csproj, 0-print_array/0-print_array.cs](0-print_array/, 0-print_array/0-print_array.csproj, 0-print_array/0-print_array.cs)**


```
martin@ubuntu:~/0x02/0-print_array$ cat 0-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = Array.CreatePrint(10);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(16);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(0);
        Console.WriteLine("Array Length:" + newArray.Length);
        Console.WriteLine("----------------");
        newArray = Array.CreatePrint(-10);
    }
}

```

```
martin@ubuntu:~/0x02/0-print_array$ ls
0-main.cs  0-print_array.cs  0-print_array.csproj  bin  obj
martin@ubuntu:~/0x02/0-print_array$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
Array Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
Array Length: 16$
----------------$
$
Array Length: 0$
----------------$
martin@ubuntu:~/0x02/0-print_array$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 1. Access an element in an array
File: **[1-element_at/, 1-element_at/1-element_at.csproj, 1-element_at/1-element_at.cs](1-element_at/, 1-element_at/1-element_at.csproj, 1-element_at/1-element_at.cs)**


```
martin@ubuntu:~/0x02/1-element_at$ cat 1-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {10, 17, -8, 4, -12, 7, 0, 1, -1, -9};

        Console.WriteLine("Element at index {0} is {1}", 4, Array.elementAt(array, 4));
        Console.WriteLine("Element at index {0} is {1}", 9, Array.elementAt(array, 9));
        Console.WriteLine("Element at index {0} is {1}", 0, Array.elementAt(array, 0));
        Array.elementAt(array, -7);
    }
}

```

```
martin@ubuntu:~/0x02/1-element_at$ dotnet run
Element at index 4 is -12
Element at index 9 is -9
Element at index 0 is 10
Index out of range
martin@ubuntu:~/0x02/1-element_at$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 2. Replace element
File: **[2-replace_element/, 2-replace_element/2-replace_element.csproj, 2-replace_element/2-replace_element.cs](2-replace_element/, 2-replace_element/2-replace_element.csproj, 2-replace_element/2-replace_element.cs)**


```
martin@ubuntu:~/0x02/2-replace_element$ cat 2-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0, 1, 2, 3, 4, 5, 6};

        PrintArray(array);
        Array.ReplaceElement(array, 1, 98);
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        int i;

        for (i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
    }
}
martin@ubuntu:~/0x02/2-replace_element$

```

```
martin@ubuntu:~/0x02/2-replace_element$ ls
2-main.cs             2-replace_element.csproj  obj
2-replace_element.cs  bin
martin@ubuntu:~/0x02/2-replace_element$ dotnet run
0 1 2 3 4 5 6
0 98 2 3 4 5 6
martin@ubuntu:~/0x02/2-replace_element$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 3. Print an array of integers... in reverse!
File: **[3-print_array_reverse/, 3-print_array_reverse/3-print_array_reverse.csproj, 3-print_array_reverse/3-print_array_reverse.cs](3-print_array_reverse/, 3-print_array_reverse/3-print_array_reverse.csproj, 3-print_array_reverse/3-print_array_reverse.cs)**


```
martin@ubuntu:~/0x02/3-print_array_reverse$ cat 3-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] array2 = null;
        int[] array3 = {};
        int[] array4 = {98, -10, 0, 972, -42};

        Array.Reverse(array1);
        Array.Reverse(array2);
        Array.Reverse(array3);
        Array.Reverse(array4);
    }
}
martin@ubuntu:~/0x02/3-print_array_reverse$

```

```
martin@ubuntu:~/0x02/3-print_array_reverse$ ls
3-main.cs                 3-print_array_reverse.csproj  obj
3-print_array_reverse.cs  bin
martin@ubuntu:~/0x02/3-print_array_reverse$ dotnet run | cat -e
9 8 7 6 5 4 3 2 1 0$
$
$
-42 972 0 -10 98$
martin@ubuntu:~/0x02/3-print_array_reverse$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 4. Print a list of integers
File: **[4-print_list/, 4-print_list/4-print_list.csproj, 4-print_list/4-print_list.cs](4-print_list/, 4-print_list/4-print_list.csproj, 4-print_list/4-print_list.cs)**


```
martin@ubuntu:~/0x02/4-print_list$ cat 4-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> newList;

        newList = List.CreatePrint(10);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(16);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(0);
        Console.WriteLine("List Length: " + newList.Count);
        Console.WriteLine("----------------");
        newList = List.CreatePrint(1);
        Console.WriteLine("List Length: " + newList.Count);        
    }
}
martin@ubuntu:~/0x02/4-print_list$

```

```
martin@ubuntu:~/0x02/4-print_list$ ls
4-main.cs  4-print_list.cs  4-print_list.csproj  bin  obj
martin@ubuntu:~/0x02/4-print_list$ dotnet run | cat -e
0 1 2 3 4 5 6 7 8 9$
List Length: 10$
----------------$
0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15$
List Length: 16$
----------------$
$
List Length: 0$
----------------$
0$
List Length: 1$
martin@ubuntu:~/0x02/4-print_list$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 5. Find the max
File: **[5-max_integer/, 5-max_integer/5-max_integer.csproj, 5-max_integer/5-max_integer.cs](5-max_integer/, 5-max_integer/5-max_integer.csproj, 5-max_integer/5-max_integer.cs)**


```
martin@ubuntu:~/0x02/5-max_integer$ cat 5-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8};
        List<int> myList2 = new List<int>() {98, 972, 971, -32, 972, 972, -727};

        Console.WriteLine("Max: " + List.MaxInteger(myList1));
        Console.WriteLine("Max: " + List.MaxInteger(myList2));
    }
}
martin@ubuntu:~/0x02/5-max_integer$

```

```
martin@ubuntu:~/0x02/5-max_integer$ ls
5-main.cs  5-max_integer.cs  5-max_integer.csproj  bin  obj
martin@ubuntu:~/0x02/5-max_integer$ dotnet run
Max: 1024
Max: 972
martin@ubuntu:~/0x02/5-max_integer$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 6. Only by 2
File: **[6-divisible_by_2/, 6-divisible_by_2/6-divisible_by_2.csproj, 6-divisible_by_2/6-divisible_by_2.cs](6-divisible_by_2/, 6-divisible_by_2/6-divisible_by_2.csproj, 6-divisible_by_2/6-divisible_by_2.cs)**


```
martin@ubuntu:~/0x02/6-divisible_by_2$ cat 6-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5, 6};
        List<bool> result = new List<bool>();
        int i;

        result = List.DivisibleBy2(myList);

        for (i = 0; i < myList.Count; i++)
        {
            if (result[i] == true)
                Console.WriteLine(myList[i] + " is divisible by 2");
            else
                Console.WriteLine(myList[i] + " is not divisible by 2");
        }
    }
}
martin@ubuntu:~/0x02/6-divisible_by_2$

```

```
martin@ubuntu:~/0x02/6-divisible_by_2$ dotnet run
1 is not divisible by 2
2 is divisible by 2
3 is not divisible by 2
4 is divisible by 2
5 is not divisible by 2
6 is divisible by 2
martin@ubuntu:~/0x02/6-divisible_by_2$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 7. Delete at
File: **[7-delete_at/, 7-delete_at/7-delete_at.csproj, 7-delete_at/7-delete_at.cs](7-delete_at/, 7-delete_at/7-delete_at.csproj, 7-delete_at/7-delete_at.cs)**


```
martin@ubuntu:~/0x02/7-delete_at$ cat 7-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        List.DeleteAt(myList, 2);

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}
martin@ubuntu:~/0x02/7-delete_at$

```

```
martin@ubuntu:~/0x02/7-delete_at$ ls
7-delete_at.cs  7-delete_at.csproj  7-main.cs  bin  obj
martin@ubuntu:~/0x02/7-delete_at$ dotnet run
1
2
3
4
5
----------
1
2
4
5
martin@ubuntu:~/0x02/7-delete_at$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 8. Number of keys
File: **[8-number_keys/, 8-number_keys/8-number_keys.csproj, 8-number_keys/8-number_keys.cs](8-number_keys/, 8-number_keys/8-number_keys.csproj, 8-number_keys/8-number_keys.cs)**


```
martin@ubuntu:~/0x02/8-number_keys$ cat 8-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
    }
}
martin@ubuntu:~/0x02/8-number_keys$

```

```
martin@ubuntu:~/0x02/8-number_keys$ ls
8-main.cs  8-number_keys.cs  8-number_keys.csproj  bin  obj
martin@ubuntu:~/0x02/8-number_keys$ dotnet run
Number of keys: 3
martin@ubuntu:~/0x02/8-number_keys$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 9. Update dictionary
File: **[9-add_key_value/, 9-add_key_value/9-add_key_value.csproj, 9-add_key_value/9-add_key_value.cs](9-add_key_value/, 9-add_key_value/9-add_key_value.csproj, 9-add_key_value/9-add_key_value.cs)**


```
martin@ubuntu:~/0x02/9-add_key_value$ cat 9-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        string key;
        string value;

        key = "school";
        value = "Holberton";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("------------------");

        key = "city";
        value = "San Francisco";

        Dictionary.AddKeyValue(myDict, key, value);

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
martin@ubuntu:~/0x02/9-add_key_value$

```

```
martin@ubuntu:~/0x02/9-add_key_value$ ls
9-add_key_value.cs  9-add_key_value.csproj  9-main.cs  bin  obj
martin@ubuntu:~/0x02/9-add_key_value$ dotnet run
school: Holberton
---------
school: Holberton
------------------
------------------
school: Holberton
city: San Francisco
---------
school: Holberton
city: San Francisco
martin@ubuntu:~/0x02/9-add_key_value$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 10. Delete from dictionary
File: **[10-delete_key_value/, 10-delete_key_value/10-delete_key_value.csproj, 10-delete_key_value/10-delete_key_value.cs](10-delete_key_value/, 10-delete_key_value/10-delete_key_value.csproj, 10-delete_key_value/10-delete_key_value.cs)**


```
martin@ubuntu:~/0x02/10-delete_key_value$ cat 10-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("----------------");

        newDict = Dictionary.DeleteKeyValue(myDict, "track");

        foreach (KeyValuePair<string, string> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("-----");

        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
martin@ubuntu:~/0x02/10-delete_key_value$

```

```
martin@ubuntu:~/0x02/10-delete_key_value$ ls
10-delete_key_value.cs  10-delete_key_value.csproj  10-main.cs  bin  obj
martin@ubuntu:~/0x02/10-delete_key_value$ dotnet run
language: C
track: low level
school: Holberton
address: 972 Mission St.
city: San Francisco
----------------
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
-----
language: C
school: Holberton
address: 972 Mission St.
city: San Francisco
martin@ubuntu:~/0x02/10-delete_key_value$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 11. Multiply by 2
File: **[11-multiply_by_2/, 11-multiply_by_2/11-multiply_by_2.csproj, 11-multiply_by_2/11-multiply_by_2.cs](11-multiply_by_2/, 11-multiply_by_2/11-multiply_by_2.csproj, 11-multiply_by_2/11-multiply_by_2.cs)**


```
martin@ubuntu:~/0x02/11-multiply_by_2$ cat 11-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Mary", 14);
        myDict.Add("Molly", 16);

        newDict = Dictionary.MultiplyBy2(myDict);

        foreach (KeyValuePair<string, int> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("--------------------");

        foreach (KeyValuePair<string, int> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
martin@ubuntu:~/0x02/11-multiply_by_2$

```

```
martin@ubuntu:~/0x02/11-multiply_by_2$ ls
11-main.cs           11-multiply_by_2.csproj  obj
11-multiply_by_2.cs  bin
martin@ubuntu:~/0x02/11-multiply_by_2$ dotnet run
John: 12
Alex: 8
Bob: 14
Mary: 14
Molly: 16
--------------------
John: 24
Alex: 16
Bob: 28
Mary: 28
Molly: 32
martin@ubuntu:~/0x02/11-multiply_by_2$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 12. Print sorted dictionary
File: **[12-print_sorted_dictionary/, 12-print_sorted_dictionary/12-print_sorted_dictionary.csproj, 12-print_sorted_dictionary/12-print_sorted_dictionary.cs](12-print_sorted_dictionary/, 12-print_sorted_dictionary/12-print_sorted_dictionary.csproj, 12-print_sorted_dictionary/12-print_sorted_dictionary.cs)**


```
martin@ubuntu:~/0x02/12-print_sorted_dictionary$ cat 12-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}
martin@ubuntu:~/0x02/12-print_sorted_dictionary$

```

```
martin@ubuntu:~/0x02/12-print_sorted_dictionary$ ls
12-main.cs                         bin
12-print_sorted_dictionary.cs      obj
12-print_sorted_dictionary.csproj
martin@ubuntu:~/0x02/12-print_sorted_dictionary$ dotnet run
address: 972 Mission St.
city: San Francisco
language: C
school: Holberton
track: low level
martin@ubuntu:~/0x02/12-print_sorted_dictionary$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 13. Best score
File: **[13-best_score/, 13-best_score/13-best_score.csproj, 13-best_score/13-best_score.cs](13-best_score/, 13-best_score/13-best_score.csproj, 13-best_score/13-best_score.cs)**


```
martin@ubuntu:~/0x02/13-best_score$ cat 13-main.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Molly", 16);
        myDict.Add("Mary", 14);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}
martin@ubuntu:~/0x02/13-best_score$

```

```
martin@ubuntu:~/0x02/13-best_score$ ls
13-best_score.cs  13-best_score.csproj  13-main.cs  bin  obj
martin@ubuntu:~/0x02/13-best_score$ dotnet run
Best Score: Molly
martin@ubuntu:~/0x02/13-best_score$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 14. Rectangular array
File: **[14-rectangular_array/, 14-rectangular_array/14-rectangular_array.csproj, 14-rectangular_array/14-rectangular_array.cs](14-rectangular_array/, 14-rectangular_array/14-rectangular_array.csproj, 14-rectangular_array/14-rectangular_array.cs)**


```
martin@ubuntu:~/0x02/14-rectangular_array$ ls
14-rectangular_array.cs  14-rectangular_array.csproj  bin  obj
martin@ubuntu:~/0x02/14-rectangular_array$ dotnet run | cat -e
0 0 0 0 0$
0 0 0 0 0$
0 0 1 0 0$
0 0 0 0 0$
0 0 0 0 0$
martin@ubuntu:~/0x02/14-rectangular_array$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


### 15. Matrix squared
File: **[15-square_matrix/, 15-square_matrix/15-square_matrix.csproj, 15-square_matrix/15-square_matrix.cs](15-square_matrix/, 15-square_matrix/15-square_matrix.csproj, 15-square_matrix/15-square_matrix.cs)**


```
martin@ubuntu:~/0x02/15-square_matrix$ cat 15-main.cs
using System;
class Program
{
    static void Main(string[] args)
    {
        int i, j;
        int[,] squareMatrix;
        int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        squareMatrix = Matrix.Square(myMatrix);

        for (i = 0; i < squareMatrix.GetLength(0); i++)
        {
            for (j = 0; j < squareMatrix.GetLength(1); j++)
            {
                Console.Write(squareMatrix[i, j]);
                if (j != squareMatrix.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
martin@ubuntu:~/0x02/15-square_matrix$

```

```
martin@ubuntu:~/0x02/15-square_matrix$ ls
15-main.cs           15-square_matrix.csproj  obj
15-square_matrix.cs  bin
martin@ubuntu:~/0x02/15-square_matrix$ dotnet run
0 1 4
9 16 25
36 49 64
martin@ubuntu:~/0x02/15-square_matrix$

```



*[top](#0x02-C---Data-Structures:-Arrays,-Lists,-Dictionaries)*

---


