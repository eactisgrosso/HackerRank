using System;

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

        public static string LowestPermutation(this string s) {
            var array = s.ToCharArray();

            //Find non-increasing suffix
            int i;
            for(i = array.Length-1; i > 0; i--){
                if (array[i - 1] < array[i])
                break;
            }

            if (i <= 0) //Already the last permutation
                return s;
            
            //Find greater than the pivot in the suffix, and swap them
            int j;
            for(j = array.Length - 1; array[j] <= array[i - 1]; j--)
            {}
            array.Swap(j, i - 1);
            
            array.Reverse(i, array.Length-1); //Reverse suffix

            return new string(array);
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