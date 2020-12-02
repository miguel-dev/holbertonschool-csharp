using System;

class Program
{
    static void Main(string[] args)
    {
        for (char a = 'a'; a <= 'z'; a++)
	{
            if (a != 'q' && a != 'e')
	    {
                Console.Write(a);
	    }
        }
    }
}
