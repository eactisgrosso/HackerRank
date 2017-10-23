using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class FindtheMedian : IChallenge
    {
        public void Run()
        {
            Console.ReadLine();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(input.Median());  
        }

    }
}