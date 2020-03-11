using System;

namespace _18_matrix_matrix_mul
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new double[,] { { 1, 2 }, { 4, 5 }, { 7, 8 } };
            var b = new double[,] {{2,3},{4,5}};

            Console.WriteLine("rows {0}, Columns {1}", a.GetLength(0), a.GetLength(1));

           var matrix =  MatrixMath.Multiply(a,b);
           var s = matrix;
            Console.WriteLine("Row: |{0}|{1}|", s[0,0], s[0,1]);
            Console.WriteLine("Row: |{0}|{1}|", s[1,0], s[1,1]);
            Console.WriteLine("Row: |{0}|{1}|", s[2,0], s[2,1]);
        }
    }
}
