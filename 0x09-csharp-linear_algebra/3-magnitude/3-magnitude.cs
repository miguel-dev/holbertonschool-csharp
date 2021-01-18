using System;

/// <summary>Class for vector operations</summary>
class VectorMath
{
    /// <summary>Calculates the magnitude of a Vector</summary>
    public static double Magnitude(double[] vector)
    {
        int length = vector.Length;

        if (length == 2)
        {
            return Math.Sqrt(Math.Pow(vector[0], 2.0) + Math.Pow(vector[1], 2.0));
        }
        else if (length == 3)
        {
            return Math.Sqrt(Math.Pow(vector[0], 2.0) + Math.Pow(vector[1], 2.0) + Math.Pow(vector[2], 2.0));
        }
        else
        {
            return -1;
        }
    }
}
