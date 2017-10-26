using System;

namespace HackerRank.Algorithms.Sorting
{
    // https://www.hackerrank.com/challenges/countingsort2/problem
    public class CountingSort2 : IChallenge
    {
        const int SIZE = 100;
        public void Run()
        {
            Console.ReadLine();
            var array = new int[SIZE];
     
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            foreach(var i in input){
                array[i]++;
            }
            for(var i = 0; i < SIZE; i++){
                var count = array[i];
                for (int j = 0; j < count; j++) {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}