using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting 
{
    public class BigSorting : IChallenge
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for(int unsorted_i = 0; unsorted_i < n; unsorted_i++){
                unsorted[unsorted_i] = Console.ReadLine();   
            }
            unsorted.IntroSort((string a,string b) => {
                return a.CompareOrdinalTo(b);
            });
            Console.WriteLine(string.Join("\n",unsorted));
        }
    }
}