using System.Linq;
using System;
using System.Collections.Generic;
using static System.Console;

class List {
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength) {
        List<int> result = new List<int>();
        
        int max = list1.Count > list2.Count ? list1.Count : list2.Count;

        for(int i = 0 ; i < max; i++)
        {
            try 
            {
                result.Add(list1[i] / list2[i]);

            }
            catch (DivideByZeroException)
            {
                WriteLine("Cannot divide by zero");
                result.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                WriteLine("Out of range");
            }
        } 

        return result;
    }
}