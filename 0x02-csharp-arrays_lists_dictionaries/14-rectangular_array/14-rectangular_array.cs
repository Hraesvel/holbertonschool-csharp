using System;
using System.Collections.Generic;
class Program {
    static void Main(string[] args) {
        int[,] matrix = new int[5,5];
        matrix[2,2] = 1;

        for(int a = 0 ; a < 5; a++) 
        {
            var temp = new List<int>();
            for(int b = 0 ; b < 5; b++) {
                temp.Add(matrix[a,b]);
            }
            Console.WriteLine("{0}", string.Join(" ", temp));
        }

    }
}