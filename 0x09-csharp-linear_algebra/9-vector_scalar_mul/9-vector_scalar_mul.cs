using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        int length = vector.Length;
        double[] result2d = new double[2];
        double[] result3d = new double[3];
        double[] res_error = {-1};

        if (length == 2)
        {
            result2d[0] = vector[0] * scalar;
            result2d[1] = vector[1] * scalar;
            return result2d;
        }
        else if (length == 3)
        {
            result3d[0] = vector[0] * scalar;
            result3d[1] = vector[1] * scalar;
            result3d[2] = vector[2] * scalar;
            return result3d;
        }
        else
        {
            return res_error;
        }
    }
}