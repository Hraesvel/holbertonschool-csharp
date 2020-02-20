using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using static System.Console;

[assembly: InternalsVisibleToAttribute("MyMath.Tests")]
namespace MyMath
{

    /// <summary> Class with methods that handle math operations</summary>
    public class Operations
    {
        /// <summary> Added to Interger types together</summary>
        /// <param a = "left side"></param>
        /// <param b = "right side"></param>
        /// <returns> Sum of left and right side </returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}