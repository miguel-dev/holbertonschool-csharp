using System;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] matrix_res = new double[2, 2];
        double[,] matrix_err = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return matrix_err;

        if (direction != 'x' && direction != 'y')
            return matrix_err;

        if (direction == 'x')
        {
            matrix_res[0, 0] = matrix[0, 0] + (factor * matrix[0, 1]);
            matrix_res[0, 1] = matrix[0, 1];
            matrix_res[1, 0] = matrix[1, 0] + (factor * matrix[1, 1]);
            matrix_res[1, 1] = matrix[1, 1];
        }
        else if (direction == 'y')
        {
            matrix_res[0, 0] = matrix[0, 0];
            matrix_res[0, 1] = matrix[0, 1] + (factor * matrix[0, 0]);
            matrix_res[1, 0] = matrix[1, 0];
            matrix_res[1, 1] = matrix[1, 1] + (factor * matrix[1, 0]);
        }
        return matrix_res;
    }
}