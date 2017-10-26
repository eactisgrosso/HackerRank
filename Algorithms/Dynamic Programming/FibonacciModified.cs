using System;
using System.Numerics;
using HackerRank.Library;

namespace HackerRank.Algorithms.DynamicProgramming 
{
    // https://www.hackerrank.com/challenges/fibonacci-modified/problem
    public class FibonacciModified : IChallenge
    {
        public void Run()
        {
            string [] input = Console.ReadLine().Split(); //0 1 5
            var t0 = BigInteger.Parse(input[0]);
            var t1 = BigInteger.Parse(input[1]);
            var n = int.Parse(input[2]);
            
            for(int i = 2; i < n; i++) {
                var t2 = (t1 * t1) + t0;
                t0 = t1;
                t1 = t2;
            }

            Console.WriteLine(t1);
        }
    }
}