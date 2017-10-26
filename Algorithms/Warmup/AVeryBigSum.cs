using System;

namespace HackerRank.Algorithms.Warmup 
{
    public class AVeryBigSum : IChallenge
    {
        static long aVeryBigSum(int n, long[] ar) {
            long sum = 0;
            foreach(var l in ar)
                sum += l;
            return sum;
        }
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp,Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
    }
}