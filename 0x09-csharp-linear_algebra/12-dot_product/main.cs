using System;

class Program
{
    static void Main(string[] args)
    {
        var s = VectorMath.DotProduct(new double[]{-4, 0, 10}, new double[]{3, 7, -9});
        Console.WriteLine("{0}", s);
    }
}

