using System;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    public class BreakingTheRecords : IChallenge
    { 
        static int[] getRecord(int[] s){
            var min = s[0];
            var max = s[0];
            int minBroken = 0, maxBroken = 0;    

            foreach(var points in s) { 
                if (points > max){
                    max = points;
                    maxBroken++;
                }
                if (points < min){
                    min = points;
                    minBroken++;
                }
            }

            return new int[2]{maxBroken,minBroken};
        }

        public void Run()
        {
            Console.ReadLine();
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp,Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}