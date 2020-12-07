using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
        }
    
        int j = 0;
        int i = 0;
        while (i < length)
        {
            j = 0;
            while(j < i)
            {
                Console.Write(" ");
                j++;
            }
            Console.WriteLine("\\");
            i++;
        }
    }
}