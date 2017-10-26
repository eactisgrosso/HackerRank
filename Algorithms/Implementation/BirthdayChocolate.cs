using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/the-birthday-bar/problem
    public class BirthdayChocolate : IChallenge
    { 
        static int solve(int[] s, int d, int m){
            var counter = 0;    
            for(var i = 0; i < s.Length - (m - 1); i++)
                if (s.Skip(i).Take(m).Sum() == d) counter++;

            return counter;
        }

        public void Run()
        {
            Console.ReadLine();
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp,Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(s, d, m);
            Console.WriteLine(result);
        }
    }
}