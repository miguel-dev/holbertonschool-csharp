using System;
using System.Collections.Generic;
class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> set = new HashSet<int>(myList);
        int Sum = 0;
        foreach (int element in set)
        {
            Sum += element;
        }
        return Sum;
    }
}