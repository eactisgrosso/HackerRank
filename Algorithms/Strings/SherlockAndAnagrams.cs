using System;
using System.Linq;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings 
{
    // https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem
    public class SherlockAndAnagrams : IChallenge
    {
        static int sherlockAndAnagrams(string s){
            var pairs = new Dictionary<string,int>();
            for (int i = 0; i < s.Length; i++) 
            {
                for (int j = i + 1; j <= s.Length; j++) 
                {
                    var sub = s.Substring(i, j-i);
                    var hash = string.Join(".", sub.CharFrequency());
                    if (!pairs.ContainsKey(hash)) {
                        pairs.Add(hash, 0);
                    }
                    pairs[hash]++;
                }
            }

            return pairs.Sum(x => x.Value * (x.Value - 1)/2);
        }
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s = Console.ReadLine();
                int result = sherlockAndAnagrams(s);
                Console.WriteLine(result);
            }
        }
    }
}