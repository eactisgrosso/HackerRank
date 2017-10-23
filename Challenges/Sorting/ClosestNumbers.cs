using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class ClosestNumbers : IChallenge
    {
        public void Run()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            array.QuickSort();

            var pairs = new List<int[]>();
            int min = int.MaxValue;
            for(var i = 0; i < n - 1; i++)
            {
                var diff = array[i+1] - array[i];
                diff = (diff < 0) ? -diff : diff;
                if (diff < min){
                    min = diff;
                    pairs.Clear();
                    pairs.Add(new int[2]{array[i], array[i+1]});
                }else if (diff == min){
                    pairs.Add(new int[2]{array[i], array[i+1]});
                }
            }

            foreach(var pair in pairs) Console.Write($"{pair[0]} {pair[1]} ");
        }
    }
}