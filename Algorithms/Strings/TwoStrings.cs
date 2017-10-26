using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Strings 
{
    public class TwoStrings : IChallenge
    {
        static string twoStrings(string s1, string s2){
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return "NO";

            HashSet<char> chars = new HashSet<char>();
            for(var i = 0; i < s1.Length; i++)
                chars.Add(s1[i]);
        
            for(var j = 0; j < s2.Length; j++)
                if (chars.Contains(s2[j])) return "YES";

            return "NO";
        }
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string result = twoStrings(s1, s2);
                Console.WriteLine(result);
            }
        }
    }
}