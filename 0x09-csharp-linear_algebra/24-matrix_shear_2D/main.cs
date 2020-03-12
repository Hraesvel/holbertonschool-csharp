using System;


class Program
{
    static void Main(string[] args)
    {
        var a = new double[,]
        {
                {1, 2},
                {3, 4},
        };

        var s = MatrixMath.Shear2D(a, 'y', 2);
        Console.WriteLine("success?: |{0}|", s[0,0]);

        Console.WriteLine("0: |{0}|{1}|", s[0,0], s[0,1]);
        Console.WriteLine("1: |{0}|{1}|", s[1,0], s[1,1]);
    }
}

