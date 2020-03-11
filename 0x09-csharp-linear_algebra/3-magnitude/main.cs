using System.Numerics;
using System; 

    class Program
    {
        static void Main(string[] args)
        {
          var mag =  VectorMath.Magnitude(new double[] {7, -3, -9});
          Console.WriteLine("mag is {0}", mag);
        }
    }

