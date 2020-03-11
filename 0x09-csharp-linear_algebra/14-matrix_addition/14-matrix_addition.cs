using System.Linq;
using System;

class MatrixMath {
    public static double[,] Add(double[,] matrix1, double[,] matrix2) {
        if (!IsMatrix(matrix1) || !IsMatrix(matrix2) || matrix1.GetLength(0) != matrix2.GetLength(0))
            return new double[,] {{-1}};
        

        var size = matrix1.GetLength(0);

        double[,] sum = new double[size,size];

        for (int r = 0; r < size; r++)
            for (int c = 0; c < size; c++)
            sum[r,c] = matrix1[r,c] + matrix2[r,c];



        return sum;

    }

    static bool IsMatrix(double[,] matrix) {
        int size = 0;

        if ((size = matrix.GetLength(0)) != matrix.GetLength(1) || (size < 2 || size > 3))
        {
            return false;
        }

        return true;
    }


}