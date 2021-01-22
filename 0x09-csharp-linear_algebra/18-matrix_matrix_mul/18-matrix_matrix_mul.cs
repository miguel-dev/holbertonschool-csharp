using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);
        double[,] matrix = new double[rows1, cols2];
        double[,] matrix_err = {{-1}};

        if (cols1 == rows2)
        {
            for (int r = 0; r < rows1; r++)
            {
                for (int c = 0; c < cols2; c++)
                {
                    for (int i = 0; i < rows2; i++)
                    {
                            matrix[r, c] += matrix1[r, i] * matrix2[i, c];
                    }
                }
            }
            return matrix;
        }
        else
        {
            return matrix_err;
        }
    }
}