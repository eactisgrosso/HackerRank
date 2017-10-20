using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class RunningTime : IChallenge
    {
        public void Run()
        {
            int[] A = new int[]{2,1,3,1,2};
            CountShifts(A);
        }

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
    }
}