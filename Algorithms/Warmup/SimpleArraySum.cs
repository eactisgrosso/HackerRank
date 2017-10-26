using System;

namespace HackerRank.Algorithms.Warmup 
{
    // https://www.hackerrank.com/challenges/simple-array-sum/problem 
    public class SimpleArraySum : IChallenge
    {
        static int simpleArraySum(int n, int[] ar) {
            int sum = 0;
            for(var i = 0; i < n; i++)
                sum+=ar[i];
            return sum;
        }
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }
    }
}