using System;


    class Program
    {
        static void Main(string[] args)
        {
            var a = new double[,] {{-13, 10, 8} ,{2, 0, 14}, {-4, -5, 2}};
            
            var s = MatrixMath.MultiplyScalar(a,4);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[0,0], s[0,1],s[0,2]);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[1,0], s[1,1],s[1,2]);
            Console.WriteLine("|{0}|{1}|{2}|\n", s[2,0], s[2,1],s[2,2]);
            
        }
    }

