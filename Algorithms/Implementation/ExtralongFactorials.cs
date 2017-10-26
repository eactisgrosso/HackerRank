using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/extra-long-factorials/problem
    public class ExtraLongFactorials : IChallenge
    { 
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(n.Factorial());
        }
    }
}