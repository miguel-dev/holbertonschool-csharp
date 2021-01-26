using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] inverse = new double[2, 2];
        double determinant = 0;
        double[,] error = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return error;
        }

        determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);

        if (determinant == 0)
        {
            return error;
        }

        inverse[0, 0] = matrix[1, 1] / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        inverse[0, 1] = -matrix[0, 1] / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        inverse[1, 0] = -matrix[1, 0] / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
        inverse[1, 1] = matrix[0, 0] / ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));

        return inverse;
    }
}