using System;

/// <summary>Class for vector operations</summary>
class VectorMath
{
    /// <summary>Calculates the magnitude of a Vector</summary>
    public static double Magnitude(double[] vector)
    {
        double magnitude = 0;

        if (vector.Length == 2)
        {

            magnitude = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2));
            return Math.Round(magnitude, 1, MidpointRounding.ToEven);
        }
        else if (vector.Length == 3)
        {
            magnitude = Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
            return Math.Round(magnitude, 1, MidpointRounding.ToEven);
        }
        else
        {
            return (-1);
        }
    }
}
