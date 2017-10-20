using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class CorrectnessInvariant : IChallenge
    {
        public void Run()
        {
            int[] A = new int[]{2,4,3,5,6,1};
            Sort(A);
        }

        static void Sort(int[] A) 
        {
            var j = 0; 
            for (var i = 1; i < A.Length; i++) { 
                var value = A[i]; 
                j = i - 1; 
                while (j >= 0 && value < A[j]) { 
                    A[j + 1] = A[j];
                    j = j - 1; 
                } 
                A[j + 1] = value; 
            } 
            Console.WriteLine(string.Join(" ", A));
        }
    }
}