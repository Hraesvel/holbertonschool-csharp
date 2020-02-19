using System.Runtime.CompilerServices;
using System;
using static System.Console;

[assembly: InternalsVisibleToAttribute("Text.Tests")]

namespace Text
{
    /// <summary> Class with methods to inspect and manipulate strings</summary>
    public class Str
    {
        /// <summary> check a string is a palindrome</summary>
        /// <param s = "string to test"></param>
        ///<returns> Bool </returns>
        public static bool IsPalindrome(string s)
        {
            string clean = "";
            int len = 0;
            if (string.IsNullOrEmpty(s))
                return true;
            foreach (char c in s)
            {
                if (char.IsPunctuation(c) || char.IsSeparator(c))
                    continue;
                clean += char.ToLower(c);
                len++;
            }

            len -= 1;

            if (clean[0] != clean[len])
                return false;

            for (int i = 0; i <= len; i++)
            {
                if (clean[i] != clean[len])
                    return false;
                len--;
            }

            return true;
        }
    }
}
