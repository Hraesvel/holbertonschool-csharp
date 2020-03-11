using System;

namespace _20_matrix_rotate_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new double[2,2] {{1, 2},{3, 4}};
            // var matrix = new double[2,2] 
            // {
            //     {2, 2},
            //     {9, 4}
            // };
            var s = MatrixMath.Rotate2D(matrix, -1.57);

            Console.WriteLine("0: |{0}|{1}|", s[0,0], s[0,1]);
            Console.WriteLine("1: |{0}|{1}|", s[1,0], s[1,1]);
        }
    }
}
