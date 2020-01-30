using System;
using System.Linq;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] nums = Enumerable.Range(0, size).ToArray();
        Console.WriteLine("{0}", string.Join(" ", nums));
        return nums;
    }
}