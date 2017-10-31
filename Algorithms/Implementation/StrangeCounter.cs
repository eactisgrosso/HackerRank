using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/strange-code/problem
    public class StrangeCounter : IChallenge
    { 
        static long ValueAtTime(long t) 
        {
            var cycle = ((long)(t/3d+1)).CeilingLog2();
            var lastTimeInCycle = 3*(cycle.PowerOf2()-1);
            
            return lastTimeInCycle-t+1;	
        }

        public void Run()
        {
            var t = long.Parse(Console.ReadLine());
            Console.WriteLine(ValueAtTime(t));
        }
    }
}