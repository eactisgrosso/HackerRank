using System;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/bon-appetit/problem
    public class BonAppetit : IChallenge
    { 
        static string bonAppetit(int n, int k, int b, int[] ar) {
            var sharedBill = 0;
            for (var i = 0; i < n; i++)
                if (i != k) sharedBill += ar[i];
          
            var annasShare = sharedBill / 2;
            return b == annasShare ? "Bon Appetit" : (b - annasShare).ToString();
        }

        public void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bonAppetit(n, k, b, ar));
        }
    }
}