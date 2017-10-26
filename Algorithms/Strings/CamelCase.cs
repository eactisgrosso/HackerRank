using System;
using System.Linq;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/camelcase/problem
    public class CamelCase : IChallenge
    {
        public void Run()
        {
            string s = Console.ReadLine();
            Console.WriteLine(1 + s.Count(c => char.IsUpper(c)));
        }
    }
}