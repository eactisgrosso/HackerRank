using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/picking-numbers/problem
    public class PickingNumbers : IChallenge
    { 
        public void Run()
        {
            Console.ReadLine();
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);    

            var counter = new int[100];
            foreach (var i in a) counter[i]++;

            var max = counter.Max();
            for (int i = 0; i < counter.Length - 1; i++) 
                max = Math.Max(max, counter[i] + counter[i + 1]);

            Console.Write(max);
        }

    }
}