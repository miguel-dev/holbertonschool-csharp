using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
	{
	    if (i < 10)
            {
	        Console.Write($"0{i}");
	    }
	    else
	    {    
                Console.Write(i);
	    }

	    if (i < 99)
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
