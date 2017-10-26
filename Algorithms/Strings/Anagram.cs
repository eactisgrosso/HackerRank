using System;
using System.Linq;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings 
{
    public class Anagram : IChallenge
    {
        static int anagram(string s){
            if (s.Length % 2 > 0) return -1;

            var length = s.Length/2;
            var s1 = s.Substring(0, length);
            var s2 = s.Substring(length, length);

            var s1freq = s1.CharFrequency();
            for(var i = 0; i <s2.Length; i++)
                s1freq[s2[i]-'a']--;
            
            return s1freq.Where(x => x>0).Sum();
        }
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s = Console.ReadLine();
                int result = anagram(s);
                Console.WriteLine(result);
            }
        }
    }
}