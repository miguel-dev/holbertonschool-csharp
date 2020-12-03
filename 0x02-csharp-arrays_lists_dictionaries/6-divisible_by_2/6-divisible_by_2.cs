using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> list = new List<bool>();
	foreach (int integer in myList)
	{
            if (integer % 2 == 0)
            {
                list.Add(true); 
            }
	    else
	    {
                list.Add(false);
	    }
        }
	return list;
    }
}
