using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
	int max = 0;
        foreach (int integer in myList)
	{
	    if (integer > max)
            {
                max = integer;
	    }
	}
	return max;
    }
}
