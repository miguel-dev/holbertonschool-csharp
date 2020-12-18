using System;

namespace MyMath
{
    /// <summary>Contains a method for performing Matrix division.</summary>
    public class Matrix
    {
        /// <summary>Divides elements of a Matrix.</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return matrix;
        }
    }
}
