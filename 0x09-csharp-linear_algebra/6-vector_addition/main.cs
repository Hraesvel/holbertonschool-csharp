using System;


    class Program
    {
        static void Main(string[] args)
        {
            var s = VectorMath.Add(new double[] {1,1,1}, new double[] {1,1,1});
            Console.WriteLine("{0},{1},{2}", s[0], s[1], s[2]);
        }
    }
