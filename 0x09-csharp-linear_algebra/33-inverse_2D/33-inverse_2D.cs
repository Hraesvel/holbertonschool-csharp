using System;

class MatrixMath
{
    /// <summary>
    /// calculate the inverse of a 2d matrix.
    /// </summary>
    /// <param name="matrix">matrix to solve for</param>
    /// <returns>Solve matrix else If the matrix is non-invertible or not 2D matrix, return -1</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        var det = 0.0;
        if (matrix.GetLongLength / 2 != 2 || (det = Determinant(matrix)) == 0 )
            return new double[,] { { -1 } };

        double[,] inv = new double[,] {
            {matrix[1,1], -matrix[0,1]},
            {-matrix[1,0],  matrix[0,1]}
        };

        return MatrixMath.MultiplyScalar(inv, 1 / det);


    }

    /// <summary>
    /// multiply
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns>boop</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (!IsMatrix(matrix))
            return new double[,] { { -1 } };

        for (int r = 0; r < matrix.GetLength(0); r++)
            for (int c = 0; c < matrix.GetLength(0); c++)
                matrix[r, c] *= scalar;

        return matrix;
    }

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

    /// <summary>
    /// beep boop
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>bop</returns>
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