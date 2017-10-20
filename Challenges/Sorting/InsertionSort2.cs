using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class InsertionSort2 : IChallenge
    {
        public void Run()
        {
            int[] ar2 = new int[]{1,4,3,5,6,2};
            Sort(ar2);
        }

        static void Sort(int[] ar) 
        {
            int j, unsorted;
            for (var i = 1; i < ar.Length; i++)
            {
                unsorted = ar[i];
                j = i - 1;
                while (j >= 0 && ar[j] > unsorted)
                {
                    ar[j + 1] = ar[j];
                    j--;
                }
                ar[j + 1] = unsorted;
                Console.WriteLine(string.Join(" ", ar));
            }
        }
    }
}