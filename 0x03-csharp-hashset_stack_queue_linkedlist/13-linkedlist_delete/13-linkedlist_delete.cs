using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedList<int> newLList = new LinkedList<int>(myLList);
        foreach (int value in newLList)
        {
            if (i == index)
            {
                myLList.Remove(value);
            }
            i++;
        }
    }
}
