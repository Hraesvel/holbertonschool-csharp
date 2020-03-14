using System.Linq;
using System;

class VectorMath {
    public static double Magnitude(double[] vector) {

        if (vector.Count() < 2 || vector.Count() > 3)
            return -1;

        for (int i = 0; i < vector.Count(); i++)
        {
            vector[i] *= vector[i];
        }
        return Math.Round(Math.Sqrt(Math.Abs(vector.Sum())), 2);

    }
}