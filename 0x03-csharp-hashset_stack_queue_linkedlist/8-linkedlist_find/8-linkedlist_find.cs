﻿using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index = 0;
	    foreach (int nodeValue in myLList)
        {
            if (nodeValue == value)
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}
