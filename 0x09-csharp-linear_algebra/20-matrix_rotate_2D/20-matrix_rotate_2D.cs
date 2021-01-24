using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] matrix_err = {{-1}};
        double[,] matrix_res = new double[2, 2];

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return matrix_err;
        }

        matrix_res[0, 0] = Math.Round((matrix[0, 0] * Math.Cos(angle)), 2) - Math.Round((matrix[0, 1] * Math.Sin(angle)), 2);
        matrix_res[0, 1] = Math.Round((matrix[0, 0] * Math.Sin(angle)), 2) + Math.Round((matrix[0, 1] * Math.Cos(angle)), 2);
        matrix_res[1, 0] = Math.Round((matrix[1, 0] * Math.Cos(angle)), 2) - Math.Round((matrix[1, 1] * Math.Sin(angle)), 2);
        matrix_res[1, 1] = Math.Round((matrix[1, 0] * Math.Sin(angle)), 2) + Math.Round((matrix[1, 1] * Math.Cos(angle)), 2);
        return matrix_res;
    }
}