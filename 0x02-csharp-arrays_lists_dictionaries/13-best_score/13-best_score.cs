using System;
using System.Collections.Generic;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string bestKey = String.Empty;
        int bestValue = 0;
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value >= bestValue)
            {
                bestValue = pair.Value;
                bestKey = pair.Key;
            }
        }
        return bestKey;
    }
}
