# 0x01. C# - if/else, loops, functions


**Table Of Context**
- [0. Positive anything is better than negative nothing](#0-Positive-anything-is-better-than-negative-nothing)
- [1. The last digit](#1-The-last-digit)
- [2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game](#2-I-sometimes-suffer-from-insomnia-And-when-I-can't-fall-asleep,-I-play-what-I-call-the-alphabet-game)
- [3. When I was having that alphabet soup, I never thought that it would pay off](#3-When-I-was-having-that-alphabet-soup,-I-never-thought-that-it-would-pay-off)
- [4. Hexadecimal printing](#4-Hexadecimal-printing)
- [5. 00...99](#5-0099)
- [6. Inventing is a combination of brains and materials. The more brains you use, the less material you need](#6-Inventing-is-a-combination-of-brains-and-materials-The-more-brains-you-use,-the-less-material-you-need)
- [7. islower](#7-islower)
- [8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important](#8-There-are-only-3-colors,-10-digits,-and-7-notes;-its-what-we-do-with-them-that's-important)
- [9. a + b](#9-a-+-b)
- [10. The shortest distance between two points is a straight line](#10-The-shortest-distance-between-two-points-is-a-straight-line)
- [11. I feel like I am diagonally parked in a parallel universe](#11-I-feel-like-I-am-diagonally-parked-in-a-parallel-universe)
- [12. Fizz Buzz](#12-Fizz-Buzz)

## Tasks


### 0. Positive anything is better than negative nothing
File: **[0-positive_or_negative/, 0-positive_or_negative/0-positive_or_negative.csproj, 0-positive_or_negative/0-positive_or_negative.cs](0-positive_or_negative/, 0-positive_or_negative/0-positive_or_negative.csproj, 0-positive_or_negative/0-positive_or_negative.cs)**


```
martin@ubuntu:~/0x01/0-positive_or_negative$ ls
0-positive_or_negative.cs  0-positive_or_negative.csproj  bin  obj
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
3 is positive
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
6 is positive
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-1 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-6 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-7 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
0 is zero
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
6 is positive
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-2 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-8 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
8 is positive
martin@ubuntu:~/0x01/0-positive_or_negative$ dotnet run
-10 is negative
martin@ubuntu:~/0x01/0-positive_or_negative$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 1. The last digit
File: **[1-last_digit/, 1-last_digit/1-last_digit.csproj, 1-last_digit/1-last_digit.cs](1-last_digit/, 1-last_digit/1-last_digit.csproj, 1-last_digit/1-last_digit.cs)**


```
martin@ubuntu:~/0x01/1-last_digit$ ls
1-last_digit.cs  1-last_digit.csproj  bin  obj
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 8903 is 3 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -6117 is -7 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 2790 is 0 and is 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 7363 is 3 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 7590 is 0 and is 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -3435 is -5 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 6661 is 1 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of -365 is -5 and is less than 6 and not 0
martin@ubuntu:~/0x01/1-last_digit$ dotnet run
The last digit of 619 is 9 and is greater than 5
martin@ubuntu:~/0x01/1-last_digit$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 2. I sometimes suffer from insomnia. And when I can't fall asleep, I play what I call the alphabet game
File: **[2-print_alphabet/, 2-print_alphabet/2-print_alphabet.csproj, 2-print_alphabet/2-print_alphabet.cs](2-print_alphabet/, 2-print_alphabet/2-print_alphabet.csproj, 2-print_alphabet/2-print_alphabet.cs)**


```
martin@ubuntu:0x01/2-print_alphabet$ ls
2-print_alphabet.cs  2-print_alphabet.csproj  bin  obj
martin@ubuntu:0x01/2-print_alphabet$ dotnet run
abcdefghijklmnopqrstuvwxyzmartin@ubuntu:0x01/2-print_alphabet$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 3. When I was having that alphabet soup, I never thought that it would pay off
File: **[3-print_alphabt/, 3-print_alphabt/3-print_alphabt.csproj, 3-print_alphabt/3-print_alphabt.cs](3-print_alphabt/, 3-print_alphabt/3-print_alphabt.csproj, 3-print_alphabt/3-print_alphabt.cs)**


```
martin@ubuntu:0x01/3-print_alphabt$ ls
3-print_alphabt.cs  3-print_alphabt.csproj  bin  obj
martin@ubuntu:0x01/3-print_alphabt$ dotnet run
abcdfghijklmnoprstuvwxyzmartin@ubuntu:0x01/3-print_alphabt$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 4. Hexadecimal printing
File: **[4-print_hexa/, 4-print_hexa/4-print_hexa.csproj, 4-print_hexa/4-print_hexa.cs](4-print_hexa/, 4-print_hexa/4-print_hexa.csproj, 4-print_hexa/4-print_hexa.cs)**


```
martin@ubuntu:0x01/4-print_hexa$ ls
4-print_hexa.cs  4-print_hexa.csproj  bin  obj
martin@ubuntu:0x01/4-print_hexa$ dotnet run
0 = 0x0
1 = 0x1
2 = 0x2
3 = 0x3
4 = 0x4
5 = 0x5
6 = 0x6
7 = 0x7
8 = 0x8
9 = 0x9
10 = 0xa
11 = 0xb
12 = 0xc
13 = 0xd
14 = 0xe
15 = 0xf
16 = 0x10
17 = 0x11
18 = 0x12
...
96 = 0x60
97 = 0x61
98 = 0x62
martin@ubuntu:0x01/4-print_hexa$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 5. 00...99
File: **[5-print_comb/, 5-print_comb/5-print_comb.csproj, 5-print_comb/5-print_comb.cs](5-print_comb/, 5-print_comb/5-print_comb.csproj, 5-print_comb/5-print_comb.cs)**


```
martin@ubuntu:0x01/5-print_comb$ ls
5-print_comb.cs  5-print_comb.csproj  bin  obj
martin@ubuntu:0x01/5-print_comb$ dotnet run
00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
martin@ubuntu:0x01/5-print_comb$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 6. Inventing is a combination of brains and materials. The more brains you use, the less material you need
File: **[6-print_comb2/, 6-print_comb2/6-print_comb2.csproj, 6-print_comb2/6-print_comb2.cs](6-print_comb2/, 6-print_comb2/6-print_comb2.csproj, 6-print_comb2/6-print_comb2.cs)**


```
martin@ubuntu:0x01/6-print_comb2$ ls
6-print_comb2.cs  6-print_comb2.csproj  bin  obj
martin@ubuntu:0x01/6-print_comb2$ dotnet run
01, 02, 03, 04, 05, 06, 07, 08, 09, 12, 13, 14, 15, 16, 17, 18, 19, 23, 24, 25, 26, 27, 28, 29, 34, 35, 36, 37, 38, 39, 45, 46, 47, 48, 49, 56, 57, 58, 59, 67, 68, 69, 78, 79, 89
martin@ubuntu:0x01/6-print_comb2$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 7. islower
File: **[7-islower/, 7-islower/7-islower.csproj, 7-islower/7-islower.cs](7-islower/, 7-islower/7-islower.csproj, 7-islower/7-islower.cs)**


```
martin@ubuntu:~/0x01/7-islower$ cat 7-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g'};
        int i;

        for (i = 0; i < letters.Length; i++)
        {
            if(Character.IsLower(letters[i]))
                Console.WriteLine("{0} is lowercase", letters[i]);
            else
                Console.WriteLine("{0} is uppercase", letters[i]);
        }
    }
}
martin@ubuntu:~/0x01/7-islower$  

```

```
martin@ubuntu:~/0x01/7-islower$ ls
7-islower.cs  7-islower.csproj  7-main.cs  bin  obj
martin@ubuntu:~/0x01/7-islower$ dotnet run
a is lowercase
A is uppercase
Q is uppercase
h is lowercase
9 is uppercase
B is uppercase
g is lowercase
martin@ubuntu:~/0x01/7-islower$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 8. There are only 3 colors, 10 digits, and 7 notes; its what we do with them that's important
File: **[8-print_last_digit/, 8-print_last_digit/8-print_last_digit.csproj, 8-print_last_digit/8-print_last_digit.cs](8-print_last_digit/, 8-print_last_digit/8-print_last_digit.csproj, 8-print_last_digit/8-print_last_digit.cs)**


```
martin@ubuntu:0x01/8-print_last_digit$ cat 8-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r);
    }
}
martin@ubuntu:0x01/8-print_last_digit$

```

```
martin@ubuntu:0x01/8-print_last_digit$ ls
8-main.cs  8-print_last_digit.cs  8-print_last_digit.csproj  bin  obj
martin@ubuntu:0x01/8-print_last_digit$ dotnet run
8044
martin@ubuntu:0x01/8-print_last_digit$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 9. a + b
File: **[9-add/, 9-add/9-add.csproj, 9-add/9-add.cs](9-add/, 9-add/9-add.csproj, 9-add/9-add.cs)**


```
martin@ubuntu:0x01/9-add$ cat 9-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", Number.Add(1, 2));
        Console.WriteLine("{0}", Number.Add(98, 0));
        Console.WriteLine("{0}", Number.Add(100, -2));
    }
}
martin@ubuntu:0x01/9-add$

```

```
martin@ubuntu:0x01/9-add$ ls
9-add.cs  9-add.csproj  9-main.cs  bin  obj
martin@ubuntu:0x01/9-add$ dotnet run
3
98
98
martin@ubuntu:0x01/9-add$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 10. The shortest distance between two points is a straight line
File: **[10-print_line/, 10-print_line/10-print_line.csproj, 10-print_line/10-print_line.cs](10-print_line/, 10-print_line/10-print_line.csproj, 10-print_line/10-print_line.cs)**


```
martin@ubuntu:0x01/10-print_line$ cat 10-main.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Line.PrintLine(3);
        Line.PrintLine(0);
        Line.PrintLine(12);
        Line.PrintLine(-98);
    }
}

```

```
martin@ubuntu:0x01/10-print_line$
martin@ubuntu:0x01/10-print_line$ ls
10-main.cs  10-print_line.cs  10-print_line.csproj  bin  obj
martin@ubuntu:0x01/10-print_line$ dotnet run | cat -e
___$
$
____________$
$
martin@ubuntu:0x01/10-print_line$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 11. I feel like I am diagonally parked in a parallel universe
File: **[11-print_diagonal/, 11-print_diagonal/11-print_diagonal.csproj, 11-print_diagonal/11-print_diagonal.cs](11-print_diagonal/, 11-print_diagonal/11-print_diagonal.csproj, 11-print_diagonal/11-print_diagonal.cs)**


```
martin@ubuntu:0x01/11-print_diagonal$ cat 11-main.cs
using System;

class ExecutePrintDiagonal
{
    static void Main(string[] args)
    {
        Line.PrintDiagonal(3);
        Line.PrintDiagonal(0);
        Line.PrintDiagonal(12);
        Line.PrintDiagonal(-98);
    }
}

```

```
martin@ubuntu:0x01/11-print_diagonal$ ls
11-main.cs  11-print_diagonal.cs  11-print_diagonal.csproj  bin  obj
martin@ubuntu:0x01/11-print_diagonal$ dotnet run | cat -e
\$
 \$
  \$
$
$
\$
 \$
  \$
   \$
    \$
     \$
      \$
       \$
        \$
         \$
          \$
           \$
$
$
martin@ubuntu:0x01/11-print_diagonal$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---


### 12. Fizz Buzz
File: **[12-fizzbuzz/, 12-fizzbuzz/12-fizzbuzz.csproj, 12-fizzbuzz/12-fizzbuzz.cs](12-fizzbuzz/, 12-fizzbuzz/12-fizzbuzz.csproj, 12-fizzbuzz/12-fizzbuzz.cs)**


```
martin@ubuntu:0x01/12-fizzbuzz$ ls
12-fizzbuzz.cs  12-fizzbuzz.csproj  bin  obj
martin@ubuntu:0x01/12-fizzbuzz$ dotnet run | cat -e
1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz$
martin@ubuntu:0x01/12-fizzbuzz$

```



*[top](#0x01-C---if/else,-loops,-functions)*

---



