using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Sorting
{
    // https://www.hackerrank.com/challenges/countingsort4/problem
    public class FullCountingSort : IChallenge
    {
        const int SIZE = 100;
        
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new List<string>[SIZE];
            var middle = n/2;
            string[] input;
            int index;
            int max = 0;

            for (var i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                index = Convert.ToInt32(input[0]);
                if (array[index] == null) array[index] = new List<string>();
                array[index].Add(i < middle ? "-" : input[1]);
                if (index > max) max = index;
            }

            for(var i = 0; i < SIZE; i++){
                if (i > max) break;
                var phrase = array[i];
                foreach (var word in phrase) {
                    Console.Write($"{word} ");
                }
            }
        }
    }
}