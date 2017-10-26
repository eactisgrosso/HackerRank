using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/kangaroo/problem
    public class Kangaroo : IChallenge
    { 
        static string kangaroo(int x1, int v1, int x2, int v2) {
            if(v1 > v2 && (x2-x1).IsDivisibleBy(v1-v2)) //checks if the diff between jump rates compensate for the diff between starting positions
                return "YES";
            else
                return "NO"; 
        }

        public void Run()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}