using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
    public class OrganizingContainersOfBalls : IChallenge
    { 
        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] M = new int[n][];
                for(int M_i = 0; M_i < n; M_i++)
                {
                    string[] M_temp = Console.ReadLine().Split(' ');
                    M[M_i] = Array.ConvertAll(M_temp,Int32.Parse);
                }

                var rowsSum = new long[n];
                var colsSum = new long[n];
                for (var row = 0; row < n; row++) {
                    for (var col = 0; col < n; col++) {
                        rowsSum[row] += M[row][col];
                        colsSum[col] += M[row][col];
                    }
                }

                Array.Sort(rowsSum);
                Array.Sort(colsSum);
               
                Console.WriteLine(rowsSum.SequenceEqual(colsSum) ? "Possible" : "Impossible");
            }
        }
    }
}