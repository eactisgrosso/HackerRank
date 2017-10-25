using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Challenges.Implementation 
{
    public class BiggerIsGreater : IChallenge
    { 
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            for(var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var output = input.LowestPermutation();
                if (input == output){
                    Console.WriteLine("no answer");
                }else{
                    Console.WriteLine(output);
                }
            }
        }
    }
}