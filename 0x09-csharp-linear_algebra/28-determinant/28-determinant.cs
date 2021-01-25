using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        double determinant = 0;

        if (rows == 2 && columns == 2)
        {
            determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return Math.Round(determinant);
        }
        else if (rows == 3 && columns == 3)
        {
            determinant = (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) + (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) + (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) - (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) - (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]) - (matrix[0, 0] * matrix[1, 2] * matrix[2, 1]);
            return Math.Round(determinant);
        }
        else
        {
            return -1;
        }
    }
}