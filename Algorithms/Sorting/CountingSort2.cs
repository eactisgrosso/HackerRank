using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting 
{
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