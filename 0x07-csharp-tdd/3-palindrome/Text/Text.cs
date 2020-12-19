using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>Contains a method to check is a string is palindrome.</summary>
    public class Str
    {
        /// <summary>Checks if a string is palindrome.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == String.Empty)
            {
                return true;
            }

            s = s.ToLower();
            s = Regex.Replace(s, @"[^\w]", string.Empty);

            int length = s.Length;
            int start = 0;
            int end = length - 1;
            bool isPalindrome = true;

            while (start != end)
            {
                if (s[start] != s[end])
                {
                    isPalindrome = false;
                    break;
                }
                start++;
                end--;
            }
            return isPalindrome;
        }
    }
}
