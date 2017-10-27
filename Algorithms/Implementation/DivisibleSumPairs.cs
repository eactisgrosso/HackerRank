using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
    public class DivisibleSumPairs : IChallenge
    { 
        static int divisibleSumPairs(int n, int k, int[] ar) {
            var pairCount = 0;
            for(var i = 0; i < n - 1; i++)
            for(var j = i + 1; j < n; j++)
                if ((ar[i] + ar[j]).IsDivisibleBy(k)) pairCount++;
          
            return pairCount;
        }
        
        public void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}