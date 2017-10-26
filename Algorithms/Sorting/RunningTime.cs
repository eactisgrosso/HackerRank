using System;
using System.Linq;

namespace HackerRank.Algorithms.Sorting
{
    public class RunningTime : IChallenge
    {
        // https://www.hackerrank.com/challenges/runningtime/problem
        static void CountShifts(int[] A) 
        {
            int shifted = 0, j = 0; 
            for (var i = 1; i < A.Length; i++) { 
                var value = A[i]; 
                j = i - 1; 
                while (j >= 0 && value < A[j]) { 
                    shifted++;
                    A[j + 1] = A[j];
                    j = j - 1; 
                } 
                A[j + 1] = value; 
            } 
            Console.WriteLine(shifted);
        }

        public void Run()
        {
            Console.ReadLine(); 
            int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            CountShifts(_ar); 
        }
    }
}