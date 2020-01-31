using System;
class Program
{
    static void Main(string[] args)
    {
        int[][] jag = new int[3][];

        jag[0] = new int[] {0,1,2,3};
        jag[1] = new int[]{0,1,2,3,4,5,6};
        jag[2] = new int[]{0,1};

        foreach(int[] i in jag){
            Console.WriteLine("{0}", string.Join(" ", i));
        }
    }
}