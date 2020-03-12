using System;

    class Program
    {
        static void Main(string[] args)
        {
        
        var a = new double[] {1, -7, 1};
        var b = new double[] {5, 2, 4};
        var cross = MatrixMath.CrossProduct(a,b);
        Console.WriteLine("Cross: {0}, {1}, {2}", cross[0], cross[1], cross[2]);

        }
    }

