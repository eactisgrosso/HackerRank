using System;
using System.Collections.Generic;

namespace HackerRank.Library
{
    public static class StringExtensions
    {
        const int ENGLISH_ALPHABET_LENGTH = 26;
        public static int CompareOrdinalTo(this string a, string b){
            if (string.IsNullOrEmpty(b)) return a.Length;

            if(a.Length == b.Length)
               return string.Compare(a,b,StringComparison.Ordinal);

            return a.Length - b.Length;
        }

        public static int[] CharFrequency(this string s)
        {
            var hash = new int[ENGLISH_ALPHABET_LENGTH]; //Supports only the 26 letters of the English alphabet
        
            for (int i=0; i<s.Length; i++)
                hash[s[i]-'a']++;
          
            return hash;
        }
    }
}