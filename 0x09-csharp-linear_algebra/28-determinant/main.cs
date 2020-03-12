using System;

namespace _28_determinant
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = new double[,]
        {
                {-4, 9, 0},
                {1, -2, 1},
                {3, -4, 2}
        };

        var s = MatrixMath.Determinant(a);
        Console.WriteLine("det:{0}", s);

        }
    }
}
