using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/migratory-birds/problem
    public class MigratoryBirds : IChallenge
    { 
        static int migratoryBirds(int n, int[] ar) {
            var frequency = new int[6];
            foreach(var birdType in ar)
                frequency[birdType]++;

            int max = 0;
            byte moreFrequent = 0;
            for(byte i = 1; i < frequency.Length; i++)
            {
                if (frequency[i] > max){
                    max = frequency[i];
                    moreFrequent = i;
                }
            }

            return moreFrequent;
        }
      
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }
    }
}