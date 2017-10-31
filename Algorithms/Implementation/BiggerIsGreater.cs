using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/bigger-is-greater/problem
    public class BiggerIsGreater : IChallenge
    { 
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            for(var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var array = input.ToCharArray();
                var output = new string(array.LowestPermutation());
                if (input == output){
                    Console.WriteLine("no answer");
                }else{
                    Console.WriteLine(output);
                }
            }
        }
    }
}