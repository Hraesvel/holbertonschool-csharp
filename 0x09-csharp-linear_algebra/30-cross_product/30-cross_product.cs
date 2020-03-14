using System;
using System.Linq;

class VectorMath
{
    /// <summary>
    ///  calculates the cross product of two 3D vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">lhs vector3</param>
    /// <param name="vector2">rhs vector3</param>
    /// <returns>corss product of 2 vectors else double[] with -1 inside</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (!VectorMath.IsVector(vector1) || !VectorMath.IsVector(vector2) ||
        vector1.Count() != vector2.Count() ||
        vector1.Count() != 3 || vector2.Count() != 3
        )
            return new double[] { -1 };

        var i = new double[2, 2]
        {
            {vector1[1], vector1[2]},
            {vector2[1], vector2[2]}
        };

        var j = new double[2, 2]
         {
            {vector1[0], vector1[2]},
            {vector2[0], vector2[2]}
        };

        var k = new double[2, 2]
         {
            {vector1[0], vector1[1]},
            {vector2[0], vector2[1]}
        };

        double[] cross = new double[3]
        {
           MatrixMath.Determinant(i),
           - MatrixMath.Determinant(j),
           MatrixMath.Determinant(k)
        };

        return cross;
    }

    static bool IsVector(double[] vec)
    {
        if (vec.Count() == 2 || vec.Count() == 3)
            return true;
        return false;
    }
}
class MatrixMath
{


    // <summary>
    /// method that calculates the determinant of a matrix
    /// </summary>
    /// <param name="matrix">matrix to calculate</param>
    /// <returns>Determinat or -1 if failure</returns>
    public static double Determinant(double[,] matrix)
    {
        int size = 0;
        if (((size = matrix.GetLength(0)) != 2 && matrix.GetLength(0) != 3) || !IsMatrix(matrix))
            return -1.0;

        double det = 0.0;

        if (size == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]);
        }
        else
        {
            det =
            matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]) -
            matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2]) +
            matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1]);
        }

        return Math.Round(det, 2);
    }
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.LongLength / 2 != 2)
            return new double[,] { { -1 } };

        double[,] rot = new double[2, 2];

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            var column = GetColumn(matrix, (uint)col);


            rot[0, col] = Math.Round((column[0] * Math.Cos(angle) + column[1] * -(Math.Sin(angle))), 2);
            rot[1, col] = Math.Round((column[0] * Math.Sin(angle) + column[1] * (Math.Cos(angle))), 2);

        }

        return rot;

    }


    public static double[] GetRow(double[,] matrix, uint row)
    {
        int size = matrix.GetLength(1);
        double[] r = new double[size];
        for (int i = 0; i < size; i++)
            r[i] = matrix[row, i];

        return r;
    }

    public static double[] GetColumn(double[,] matrix, uint column)
    {
        int size = matrix.GetLength(0);
        var col = new double[size];
        for (int i = 0; i < size; i++)
            col[i] = matrix[i, column];

        return col;
    }


    static bool IsMatrix(double[,] matrix)
    {
        int size = 0;

        if ((size = matrix.GetLength(0)) != matrix.GetLength(1) || (size < 2 || size > 3))
        {
            return false;
        }

        return true;
    }

}