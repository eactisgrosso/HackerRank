using System;
using System.Linq;
using System.Numerics;
using HackerRank.Library;

namespace HackerRank.Challenges.Implementation 
{
    public class ExtraLongFactorials : IChallenge
    { 
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(n.Factorial());
        }
    }
}