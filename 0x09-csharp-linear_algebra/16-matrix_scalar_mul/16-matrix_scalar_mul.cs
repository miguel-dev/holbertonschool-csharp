using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] matrix2d = new double[2, 2];
        double[,] matrix3d = new double[3, 3];
        double[,] matrix_err = {{-1}};
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows == 2 && columns == 2)
        {
            matrix2d[0, 0] = matrix[0, 0] * scalar;
            matrix2d[0, 1] = matrix[0, 1] * scalar;
            matrix2d[1, 0] = matrix[1, 0] * scalar;
            matrix2d[1, 1] = matrix[1, 1] * scalar;
            return matrix2d;
        }
        else if (rows == 3 && columns == 3)
        {
            matrix3d[0, 0] = matrix[0, 0] * scalar;
            matrix3d[0, 1] = matrix[0, 1] * scalar;
            matrix3d[0, 2] = matrix[0, 2] * scalar;
            matrix3d[1, 0] = matrix[1, 0] * scalar;
            matrix3d[1, 1] = matrix[1, 1] * scalar;
            matrix3d[1, 2] = matrix[1, 2] * scalar;
            matrix3d[2, 0] = matrix[2, 0] * scalar;
            matrix3d[2, 1] = matrix[2, 1] * scalar;
            matrix3d[2, 2] = matrix[2, 2] * scalar;
            return matrix3d;
        }
        else
        {
            return matrix_err;
        }
    }
}