using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/making-anagrams/problem
    public class MakingAnagrams : IChallenge
    {
        static int makingAnagrams(string s1, string s2) {
            var frequency = s1.CharFrequency();
            var deletions = 0;
            foreach(var c in s2){
                if (frequency[c-'a']==0)
                    deletions++;
                else
                    frequency[c-'a']--;
            }
            return deletions + frequency.Where(x=> x>0).Sum();
        }

        public void Run()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int result = makingAnagrams(s1, s2);
            Console.WriteLine(result);
        }
    }
}