using System;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int wordCount = 1;
            
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
