using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int length1 = vector1.Length;
        int length2 = vector2.Length;

        if (length1 == 2 && length2 == 2)
        {
            return (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]);
        }
        else if (length1 == 3 && length2 == 3)
        {
            return (vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]);
        }
        else
        {
            return -1;
        }
    }
}