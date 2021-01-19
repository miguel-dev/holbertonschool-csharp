using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int length1 = vector1.Length;
        int length2 = vector2.Length;
        double[] vector_sum2d = new double[2];
        double[] vector_sum3d = new double[3];
        double[] vector_error = {-1};

        if (length1 == 2 && length2 == 2)
        {
            vector_sum2d[0] = vector1[0] + vector2[0];
            vector_sum2d[1] = vector1[1] + vector2[1];
            return vector_sum2d;
        }
        else if (length1 == 3 && length2 == 3)
        {
            vector_sum3d[0] = vector1[0] + vector2[0];
            vector_sum3d[1] = vector1[1] + vector2[1];
            vector_sum3d[2] = vector1[2] + vector2[2];
            return vector_sum3d;
        }
        else
        {
            return vector_error;
        }
    }
}