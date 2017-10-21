using System;
using System.Text;

namespace HackerRank.Challenges.Warmup 
{
    public class Staircase : IChallenge
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var staircase = new StringBuilder();
            for(int i = 0; i < n; ++i)
                staircase.Append(' ');

            for(int i = n - 1; i >= 0; i--)
            {
                staircase.Remove(i,1);
                staircase.Append('#');
                Console.WriteLine(staircase);
            }
        }
    }
}