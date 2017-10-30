using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
    public class HackerRankInAString : IChallenge
    {
        static readonly string HACKERRANK = "hackerrank";
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s = Console.ReadLine();
                if (s.Length < HACKERRANK.Length){
                    Console.WriteLine("NO");
                    continue;
                }
                var i = 0;
                foreach(var c in s){
                    if (c == HACKERRANK[i])i++;
                    if (i == HACKERRANK.Length) break;
                }
                Console.WriteLine(i == HACKERRANK.Length ? "YES" : "NO");    
            }   
        }
    }
}