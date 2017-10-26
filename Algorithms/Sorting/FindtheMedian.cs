using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    public class FindtheMedian : IChallenge
    {
        // https://www.hackerrank.com/challenges/find-the-median/problem
        public void Run()
        {
            Console.ReadLine();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(input.Median());  
        }

    }
}