using System;

    class Program
    {
        static void Main(string[] args)
        {

            var a = new double[,] {{14, -3, 0} ,{-11, -5, 3}, {2, -9, 13}};
            
            var b = new double[,] {{6, 16, 21} ,{5, 2, 0}, {1, 3, 7}};

            var s = MatrixMath.Add(a,b);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[0,0], s[0,1],s[0,2]);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[1,0], s[1,1],s[1,2]);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[2,0], s[2,1],s[2,2]);
        }
    }
