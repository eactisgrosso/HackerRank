using System;

namespace HackerRank.Algorithms.BitManipulation
{
    // https://www.hackerrank.com/challenges/flipping-bits/problem
    public class FlippingBits : IChallenge
    {
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            for(var i = 0; i < n; i++)
            {
                var input = uint.Parse(Console.ReadLine());
                Console.WriteLine(~input);
            }
        }
    }
}