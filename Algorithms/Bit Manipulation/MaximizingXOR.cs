using System;

namespace HackerRank.Algorithms.BitManipulation
{
    // https://www.hackerrank.com/challenges/maximizing-xor/problem
    public class MaximizingXOR : IChallenge
    {
        static int maxXor(int l, int r) {
            var max = 0;
            for(var i = l; i <= r; i++)
            for(var j = i; j <= r; j++)
                max = Math.Max(max, i ^ j);
            return max;
        }

        public void Run()
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());
            
            int _r;
            _r = Convert.ToInt32(Console.ReadLine());
            
            res = maxXor(_l, _r);
            Console.WriteLine(res);
        }
    }
}