using System;

namespace Text
{
    /// <summary>Contains a method to count the number of words in a string</summary>
    public class Str
    {
        /// <summary>Determines number of words in a string</summary>
        public static int CamelCase(string s)
        {
            if (s.Equals(string.Empty))
            {
                return 0;
            }
            
            int numberWords = 1;
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                {
                    numberWords++;
                }
            }
            return numberWords;
        }
    }
}
