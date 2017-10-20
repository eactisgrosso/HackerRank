using System;
using System.Collections.Generic;
using System.Text;

using HackerRank.Challenges.Strings;
using HackerRank.Challenges.Sorting;
using HackerRank.Challenges.DynamicProgramming;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            IChallenge challenge = new FibonacciModified();
            challenge.Run();
        }
    }
}
