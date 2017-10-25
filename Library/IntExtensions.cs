using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRank.Library
{
    public static class IntExtensions
    {
        public static int FloorLog2(this int i){
            int result = 0;
            while (i >= 1)
            {
                result++;
                i = i / 2;
            }
            return result;
        }

        public static BigInteger Factorial(this int n)
        {
            BigInteger factorial = n;
            for(var i = 1; i < n; i++)
                factorial = factorial * (n-i);

            return factorial;
        }

        public static int[] Digits(this int n)
        {
            var digits = new List<int>();
            while(n > 0)
            {
                digits.Add(n % 10);
                n = n / 10;
            }
            digits.Reverse();
            return digits.ToArray();
        }
    }
}