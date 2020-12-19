using System;

namespace Text
{
    /// <summary>Contains a method to find a unique character</summary>
    public class Str
    {
        /// <summary>Returns the index of first nonrepeating character</summary>
        public static int UniqueChar(string s)
        {
            foreach (char c in s)
            {
                if (s.IndexOf(c) == s.LastIndexOf(c))
                {
                    return s.IndexOf(c);
                }
            }
            return -1;
        }
    }
}
