using System;

namespace HackerRank.Algorithms.Warmup 
{
    public class SolveMeFirst : IChallenge
    {
        static int solveMeFirst(int a, int b) { 
            return a+b;
        }
        public void Run()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
    }
}