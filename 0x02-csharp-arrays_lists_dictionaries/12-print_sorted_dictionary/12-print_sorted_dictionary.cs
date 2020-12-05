using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.Keys);
        keys.Sort();
        int length = myDict.Count;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0}: {1}", keys[i], myDict[keys[i]]);
        }
    }
}
