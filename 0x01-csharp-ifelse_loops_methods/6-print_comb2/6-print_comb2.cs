using System;

class Program
{
    static void Main(string[] args)
    {
	for (int a = 0; a < 10; a++)
	{
            for (int b = 0; b < 10; b++)
	    {
	        if (a != b && b > a)
		{
                    Console.Write($"{a}{b}", a, b);
		    if (a != 8 || b != 9)
		    {
		        Console.Write(", ");
		    }
		    else
		    {
		        Console.WriteLine();
		    }
		}
	    }
	}
    }
}
