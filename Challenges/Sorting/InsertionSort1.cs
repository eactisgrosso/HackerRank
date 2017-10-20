using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class InsertionSort1 : IChallenge
    {
        public void Run()
        {
            int[] ar1 = new int[]{2,4,6,8,1};
            Sort(ar1);
        }

        static void Sort(int[] ar) 
        {
            var j = ar.Length - 1;
            var unsorted = ar[j--];
            while (j >= 0 && ar[j] > unsorted)
            {
                ar[j + 1] = ar[j];
                Console.WriteLine(string.Join(" ", ar));
                j--;
            }
            ar[j + 1] = unsorted;
            Console.WriteLine(string.Join(" ", ar));
        }
    }
}