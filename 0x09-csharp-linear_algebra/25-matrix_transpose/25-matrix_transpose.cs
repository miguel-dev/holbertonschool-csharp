using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        double[,] transpose = new double[columns, rows];

        if (matrix.Length == 0)
            return matrix;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }
}