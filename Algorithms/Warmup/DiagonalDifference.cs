using System;

namespace HackerRank.Algorithms.Warmup 
{   
    // https://www.hackerrank.com/challenges/diagonal-difference/problem
    public class DiagonalDifference : IChallenge
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for(int a_i = 0; a_i < n; a_i++){
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
            }
           
            long diff = 0;
            for(int y = 0, x = n; y < n; ++y){
                diff += a[y][y] - a[y][--x];
            }
            diff = (diff < 0) ? -diff : diff;

            Console.WriteLine(diff);
        }
    }
}