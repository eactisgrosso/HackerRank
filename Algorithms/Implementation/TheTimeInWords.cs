using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/the-time-in-words/problem
    public class TheTimeInWords : IChallenge
    { 
        public void Run()
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            var time = new TimeSpan(h,m,0);
            Console.WriteLine(time.ToWords());
        }
    }
}