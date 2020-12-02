using System;

class Program
{
    static void Main(string[] args)
    {
	string number = null;
        for (int i = 0; i < 100; i++)
	{
	    if (i < 10)
            {
	        number = string.Format($"0{i}", i);
	    }
	    else
	    {    
                number = Convert.ToString(i);
	    }

	    if (i < 99)
            {
                number += ", ";
            }
	    else
	    {
                number += "\n";
            }
	    Console.Write(number);
	}
    }
}
