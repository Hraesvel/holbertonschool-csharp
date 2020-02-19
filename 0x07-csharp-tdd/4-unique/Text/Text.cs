using System.Linq;
using System.Collections.Generic;
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

        /// <summary> Find the index of the first unique char</summary>
        /// <param s = "string to test"></param>
        ///<returns> index of the first unique char </returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;
            int idx = 0;
            int i = 0;
            Dictionary<char, int> sentinal = new Dictionary<char, int>();
            foreach (char c in s)
            {

                if (!sentinal.TryGetValue(c, out _))
                {
                    sentinal.Add(c, i);
                    idx = i > idx ? i : idx;
                }
                else
                    sentinal[c] = -1;

                i++;
            }

            if (!sentinal.Where(kvp => kvp.Value > -1).Any())
                return -1;


            foreach (int val in sentinal.Values)
            {
                if (val >= 0 && val < idx)
                    idx = val;
            }

            return idx;
        }
    
        
    }
}
