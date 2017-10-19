using System;

namespace HackerRank.Challenges.Strings 
{
    public class TwoStrings : IChallenge
    {
        public void Run()
        {
            Console.WriteLine(Contains("hello","world"));
            Console.WriteLine(Contains("hi","world"));
            Console.ReadLine();
        }

        string Contains(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return "NO";

            System.Collections.Generic.HashSet<char> chars = new System.Collections.Generic.HashSet<char>();
            for(var i = 0; i < s1.Length; i++)
                chars.Add(s1[i]);
        
            for(var j = 0; j < s2.Length; j++)
                if (chars.Contains(s2[j])) return "YES";


            return "NO";
        }
    }
}