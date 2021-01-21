using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] matrix2d = new double[2, 2];
        double[,] matrix3d = new double[3, 3];
        double[,] matrix_err = {{-1}};
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if ((rows1 == 2 && cols1 == 2) && (rows2 == 2 && cols2 == 2))
        {
            matrix2d[0, 0] = matrix1[0, 0] + matrix2[0, 0];
            matrix2d[0, 1] = matrix1[0, 1] + matrix2[0, 1];
            matrix2d[1, 0] = matrix1[1, 0] + matrix2[1, 0];
            matrix2d[1, 1] = matrix1[1, 1] + matrix2[1, 1];
            return matrix2d;
        }
        else if ((rows1 == 3 && cols1 == 3) && (rows2 == 3 && cols2 == 3))
        {
            matrix3d[0, 0] = matrix1[0, 0] + matrix2[0, 0];
            matrix3d[0, 1] = matrix1[0, 1] + matrix2[0, 1];
            matrix3d[0, 2] = matrix1[0, 2] + matrix2[0, 2];
            matrix3d[1, 0] = matrix1[1, 0] + matrix2[1, 0];
            matrix3d[1, 1] = matrix1[1, 1] + matrix2[1, 1];
            matrix3d[1, 2] = matrix1[1, 2] + matrix2[1, 2];
            matrix3d[2, 0] = matrix1[2, 0] + matrix2[2, 0];
            matrix3d[2, 1] = matrix1[2, 1] + matrix2[2, 1];
            matrix3d[2, 2] = matrix1[2, 2] + matrix2[2, 2];
            return matrix3d;
        }
        else
        {
            return matrix_err;
        } 
    }
}