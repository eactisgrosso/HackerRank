using System;

namespace HackerRank.Library
{
    public static class StringExtensions
    {
        public static int CompareOrdinalTo(this string a, string b){
            if (string.IsNullOrEmpty(b)) return a.Length;

            if(a.Length == b.Length)
               return string.Compare(a,b,StringComparison.Ordinal);

            return a.Length - b.Length;
        }
    }
}