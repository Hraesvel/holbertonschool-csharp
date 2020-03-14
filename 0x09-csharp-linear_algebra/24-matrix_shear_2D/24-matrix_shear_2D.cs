using System;
using System.Linq;

class MatrixMath
{
    enum Direction
    {
        x = 0,
        y = 1
    }
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
            shear = new double[2, 2] { { 1, 0 }, { 0, factor } };
            for (int r1 = 0; r1 < 2; r1++)
                for (int r2 = 0; r2 < 2; r2++)
                {
                    s[r1, r2] = VectorMath.DotProduct(GetRow(shear, (uint)r2), GetRow(matrix, (uint)r1));
                }
        }

        return s;


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
    public static double Magnitude(double[] vector)
    {

        if (vector.Count() < 2 || vector.Count() > 3)
            return -1;

        for (int i = 0; i < vector.Count(); i++)
        {
            vector[i] *= vector[i];
        }
        return Math.Round(Math.Sqrt(Math.Abs(vector.Sum())), 1);

    }

    public static double[] Add(double[] vector1, double[] vector2)
    {
        int size;
        double[] sum;

        if ((size = vector1.Count()) != vector2.Count() || !IsVector(vector1) || !IsVector(vector2))
            return new double[] { -1 };

        sum = new double[size];

        for (int i = 0; i < size; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }

        return sum;

    }

    static bool IsVector(double[] vec)
    {
        if (vec.Count() == 2 || vec.Count() == 3)
            return true;
        return false;
    }

    public static double[] Multiply(double[] vector, double scalar)
    {
        if (!IsVector(vector))
            return new double[] { -1 };

        for (int i = 0; i < vector.Count(); i++)
            vector[i] *= scalar;

        return vector;
    }
}
