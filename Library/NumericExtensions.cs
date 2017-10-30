using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace HackerRank.Library
{
    public static class NumericExtensions
    {
        static readonly string[] UNITS = new[] { 
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" 
        };
        static readonly string[] TENS = new[] { 
            "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" 
        };

        public static int FloorLog2(this int i){
            return (int)((long)i).FloorLog2();
        }

        public static long FloorLog2(this long l){
            int result = 0;
            while (l >= 1)
            {
                result++;
                l = l / 2;
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

        public static bool IsDivisibleBy(this int x, int n)
        {
            return (x % n) == 0;
        }

        public static int GCD(this int x, int n)
        {
            if (n == 0) return x;
            else return GCD(n, x % n);
        }

        public static int LCM(this int x, int n)
        {
            return (x / GCD(x, n)) * n;
        }
        
        public static string ToWords(this int n)
        {
            if (n == 0)
                return UNITS[0];

            if (n < 0)
                return $"minus {ToWords(Math.Abs(n))}";

            var words = new StringBuilder();

            if ((n/1000000) > 0)
            {
                words.Append($"{ToWords(n/1000000)} million ");
                n %= 1000000;
            }

            if ((n/1000) > 0)
            {
                words.Append($"{ToWords(n/1000)} thousand ");
                n %= 1000;
            }

            if ((n/100) > 0)
            {
                words.Append($"{ToWords(n/100)} hundred ");
                n %= 100;
            }

            if (n > 0)
            {
                if (words.Length > 0)
                    words.Append("and ");

                if (n < 20)
                    words.Append(UNITS[n]);
                else
                {
                    words.Append(TENS[n/10]);
                    if ((n % 10) > 0)
                        words.Append($" {UNITS[n % 10]}");
                }
            }

            return words.ToString();
        }
    }
}