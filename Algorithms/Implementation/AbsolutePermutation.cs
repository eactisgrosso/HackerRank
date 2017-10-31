using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/absolute-permutation/problem
    public class AbsolutePermutation : IChallenge
    { 
        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < t; a0++){
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                if (k == 0)
                {
                    Console.WriteLine(1.Range(n).ToString(" "));
                    continue;
                } 
                else if(!((double)n/k).IsDivisibleBy(2))
                {
                    Console.WriteLine("-1");
                    continue;
                }
                else
                {
                    var array = new int[n+1];
                    var add = true;
                    for(int i = 1; i <= n; i++){
                        array[i] = add ? i + k : i - k;
                        add = i % k == 0 ? !add : add;
                    }
                    Console.WriteLine(array.Skip(1).ToString(" "));
                }
            }
        }
    }
}