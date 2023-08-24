using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            /// Convert the string to lowercase and remove spaces and punctuation
            string cleanedString = Regex.Replace(s.ToLower(), @"[^a-zA-Z]", "");

            /// Compare the cleaned string with its reverse
            return cleanedString == new string(cleanedString.Reverse().ToArray());
        }
    }
}
