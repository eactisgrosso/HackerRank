using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class InsertionSort : IChallenge
    {
        public void Run()
        {
            //int[] ar1 = new int[]{2,4,6,8,1};
            //Part1(ar1);
            
            int[] ar2 = new int[]{1,4,3,5,6,2};
            Part2(ar2);
        }

        static void Part1(int[] ar) 
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
        static void Part2(int[] ar) 
        {
            int j, unsorted;
            for (var i = 0; i < ar.Length - 1; i++)
            {
                j = i;
                unsorted = ar[i + 1];
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