using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using static System.Console;

[assembly : InternalsVisibleToAttribute ("MyMath.Tests")]
namespace MyMath {

    /// <summary> Class with methods that handle math operations</summary>
    public class Operations {
        /// <summary> Added to Interger types together</summary>
        /// <param a = "left side"></param>
        /// <param b = "right side"></param>
        /// <returns> Sum of left and right side </returns>
        public static int Add (int a, int b) {
            return a + b;
        }

        /// <summary> Find the Max int in a list</summary>
        /// <param nums = "List if integers"></param>
        /// <returns> Largest int in a list else 0</returns>
        public static int Max (List<int> nums) {
            if (nums is null || nums.Count == 0)
                return 0;
            int max = nums[0];
            foreach (int i in nums)
                if (i > max)
                    max = i;

            return max;
        }
    }

    /// <summary> Class with methods that handle math operations for matrix</summary>
    public class Matrix {
        /// <summary> Divied a Matrix by a given number</summary>
        /// <param matrix = "Multy demtional array"></param>
        /// <param num = "number to divide with"></param>
        /// <returns> new matrix containing divided elements, else NULL if errors </returns>
        public static int[, ] Divide (int[, ] matrix, int num) {
            if (matrix is null)
                return null;
            int row, col;
            row = matrix.GetLength (0);
            col = matrix.GetLength (1);

            int[, ] product = new int[row, col];

            for (int r = 0; r < row; r++)
                for (int c = 0; c < col; c++) {
                    try {
                        product[r, c] = matrix[r, c] / num;
                    } catch (DivideByZeroException) {
                        WriteLine ("Num cannot be 0");
                        return null;
                    }
                }

            return product;

        }
    }
}