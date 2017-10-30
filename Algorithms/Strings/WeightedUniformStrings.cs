using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/weighted-uniform-string/problem
    public class WeightedUniformStrings : IChallenge
    {
        public void Run()
        {
            string s = Console.ReadLine();
            var weights = new System.Collections.Generic.HashSet<int>();
            int weight = 0;
            for(var i = 0; i < s.Length; i++)
            {
                weights.Add(weight += s[i]-'a'+1);
                if (i == s.Length - 1 || s[i] != s[i+1]) 
                    weight = 0;
            }

            int n = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < n; a0++){
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(weights.Contains(x) ? "Yes" : "No");
            }   
        }
    }
}