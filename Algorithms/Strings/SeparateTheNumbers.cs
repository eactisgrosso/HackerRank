using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/separate-the-numbers/problem
    public class SeparateTheNumbers : IChallenge
    {
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                var s = Console.ReadLine();
                var isBeautiful = false;
                for(var len = 1; len <= s.Length/2; len++)
                {
                    var firstNumber = long.Parse(s.Substring(0,len));
                    var sequence = firstNumber;
                    var sb = new System.Text.StringBuilder();
                    while(sb.Length < s.Length) sb.Append(sequence++);
                    if (sb.ToString() == s)
                    {
                        Console.WriteLine($"YES {firstNumber}");
                        isBeautiful = true;
                        break;
                    }
                }

                if (!isBeautiful) Console.WriteLine("NO");
            }
        }
    }
}