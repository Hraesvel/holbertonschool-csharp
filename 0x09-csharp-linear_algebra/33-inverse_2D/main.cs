using System;

    class Program
    {
        static void Main(string[] args)
        {

            double[,] a = new double[,] { { 1,2 }, {3,4} };
            var s = MatrixMath.Inverse2D(a);

            Console.WriteLine("{0}|{1}", s[0,0], s[0,1]);
            Console.WriteLine("{0}|{1}", s[1,0], s[1,1]);
        }
    }

