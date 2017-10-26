using System;

namespace HackerRank.Algorithms.Warmup 
{
    // https://www.hackerrank.com/challenges/mini-max-sum/problem
    public class MiniMaxSum : IChallenge
    {
        public void Run()
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

            long min = 0L, max = 0L;
            for(var i = 0L; i < arr.Length; i++)
            {
                long sum = 0L;
                for(var j = 0L; j < arr.Length; j++)
                {
                    if (j == i) continue;
                    sum += arr[j];
                }
                if (min == 0 || sum < min) min = sum;
                if (sum > max) max = sum;
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}