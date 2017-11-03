using System;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    public class ClimbingTheLeaderboard : IChallenge
    { 
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp,Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp,Int32.Parse);

            var ranks = new int[n];
            var rank = 1;
            for (int i = 0; i < n; i++) 
            {
                if (i > 0 && scores[i] != scores[i - 1]) rank++;
                ranks[i] = rank;
            }

            for (int i = 0; i < m; i++) 
            {
                int lower = 0, upper = n - 1;
                var aliceRank = 1;
                while (lower <= upper) 
                {
                    var middle = (lower + upper) / 2;
                    if (alice[i] == scores[middle]) 
                    {
                        aliceRank = ranks[middle];
                        break;
                    } 
                    else if (alice[i] < scores[middle]) 
                    {
                        aliceRank = ranks[middle] + 1;
                        lower = middle + 1;
                    } 
                    else 
                    {
                        upper = middle - 1;
                    }
                }
                Console.WriteLine(aliceRank);
            }            
        }
    }
}