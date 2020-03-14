using System;
using System.Linq;

class MatrixMath
{
    enum Direction
    {
        x = 0,
        y = 1
    }
    /// <summary>
    /// method that shears a square 2D matrix by a given shear factor and returns the resulting matrix. 
    /// </summary>
    /// <param name="matrix">"matrix to shear"</param>
    /// <param name="direction">"x,y direction to shear in"</param>
    /// <param name="factor">"shear amount"</param>
    /// <returns>a matrix with shear applied</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {

        if (matrix.LongLength / 2 != 2)
            return new double[,] { { -1 } };

        else if (direction != 'x' && direction != 'y')
            return new double[,] { { -1 } };


        int dir = (int)direction - (int)'x';

        double[,] shear;
        double[,] s = new double[2, 2];


        if (dir == 0)
        {

            shear = new double[2, 2] { { 1, factor }, { 0, 1 } };
            for (int r1 = 0; r1 < 2; r1++)
                for (int r2 = 0; r2 < 2; r2++)
                {
                    s[r1, r2] = VectorMath.DotProduct(GetRow(shear, (uint)r2), GetRow(matrix, (uint)r1));
                }
        }
        else
        {
            shear = new double[2, 2] { { 1, 0 }, { factor, 1 } };
            for (int r1 = 0; r1 < 2; r1++)
                for (int r2 = 0; r2 < 2; r2++)
                {
                    s[r1, r2] = VectorMath.DotProduct(GetRow(shear, (uint)r2), GetRow(matrix, (uint)r1));
                }
        }

        return s;


    }
    


    public static double[] GetRow(double[,] matrix, uint row)
    {
        int size = matrix.GetLength(1);
        double[] r = new double[size];
        for (int i = 0; i < size; i++)
            r[i] = matrix[row, i];

        return r;
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

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int size = 0;
        if ((size = vector1.Count()) != vector2.Count() || !(IsVector(vector1) || IsVector(vector2)))
            return -1;

        double[] dot = new double[size];

        for (int i = 0; i < size; i++)
        {
            dot[i] = vector1[i] * vector2[i];
        }

        return dot.Sum();
    }

    static bool IsVector(double[] vec)
    {
        if (vec.Count() == 2 || vec.Count() == 3)
            return true;
        return false;
    }

}
