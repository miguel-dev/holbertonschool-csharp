using System;

/// <summary>Class for vector operations</summary>
class VectorMath
{
    /// <summary>Calculates the magnitude of a Vector</summary>
    public static double Magnitude(double[] vector)
    {
        int length = 0;
        double magnitude = 0;

        if (vector == null)
            return -1;

        length = vector.Length;
        
        if (length == 2)
        {
            try:
                magnitude = Math.Sqrt(Math.Pow(vector[0], 2.0) + Math.Pow(vector[1], 2.0));
            except:

            return Math.Round(magnitude, 1, MidpointRounding.ToEven);
        }
        else if (length == 3)
        {
            magnitude = Math.Sqrt(Math.Pow(vector[0], 2.0) + Math.Pow(vector[1], 2.0) + Math.Pow(vector[2], 2.0));
            return Math.Round(magnitude, 1, MidpointRounding.ToEven);
        }
        else
        {
            return -1;
        }
    }
}
