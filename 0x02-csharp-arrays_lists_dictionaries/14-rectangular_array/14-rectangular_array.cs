using System;

class Program
{
    static void Main(string[] args)
    {
        int [,] array = new int[5, 5] {{0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 1, 0, 0}, {0, 0, 0, 0, 0}, {0, 0, 0, 0, 0}};
        for (int rows = 0; rows < 5; rows++)
        {
            for (int columns = 0; columns < 5; columns++)
            {
                Console.Write(array[rows, columns]);
                if (columns != 4)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}