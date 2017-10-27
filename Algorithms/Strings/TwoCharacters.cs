using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Strings 
{
    // https://www.hackerrank.com/challenges/two-characters/problem
    public class TwoCharacters : IChallenge
    {
        public void Run()
        {
            Console.ReadLine();
            string s = Console.ReadLine();

            var set = new HashSet<char>(s);
            var longest = 0;
            foreach(var a in set)    
            foreach(var b in set)    
            {
                if (a == b) continue;
                var t = s.Where(c => c == a || c == b);
                if (t.Where((c,i) => i % 2 == 0).All(c => c == a) && 
                    t.Where((c,i) => i % 2 > 0).All(c => c == b)) {
                    longest = Math.Max(longest, t.Count());
                }
            }
            Console.WriteLine(longest);
        }
    }
}