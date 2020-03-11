using System;

class VectorMath
{

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
