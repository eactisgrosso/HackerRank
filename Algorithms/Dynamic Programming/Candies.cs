using System;
using System.Linq;
using System.Numerics;
using HackerRank.Library;

namespace HackerRank.Algorithms.DynamicProgramming 
{
    // https://www.hackerrank.com/challenges/candies/problem
    public class Candies : IChallenge
    {
        static long TotalCandies(int n, int[] rating) {
            var candies = new long[n];
            candies.Fill(1);

            for(int i = 1; i < n; i++)
                if(rating[i] > rating[i-1]) candies[i] = candies[i-1]+1;
            
            for(int i = n-2; i >= 0; i--)
                if(rating[i] > rating[i+1]) candies[i] = Math.Max(candies[i], candies[i+1]+1);
     
            return candies.Sum();     
        }

        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int arr_i = 0; arr_i < n; arr_i++){
                arr[arr_i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine(TotalCandies(n, arr));
        }
    }
}