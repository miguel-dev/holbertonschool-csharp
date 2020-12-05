using System;
using System.Collections.Generic;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bestKey = "None";
        int bestValue = 0;
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > bestValue)
            {
                bestValue = pair.Value;
                bestKey = pair.Key;
            }
        }
        return bestKey;
    }
}