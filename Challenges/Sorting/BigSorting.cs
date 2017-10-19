using System;
using HackerRank.Library;

namespace HackerRank.Challenges.Sorting 
{
    public class BigSorting : IChallenge
    {
        public void Run()
        {
            string[] unsorted = new string[]{"31415926535897932384626433832795","1","3","10","3","5"};
            Console.WriteLine($"Original array:{string.Join('-', unsorted)}");
            
            unsorted.QuickSort((string a,string b) => {
                return a.CompareOrdinalTo(b);
            });

            Console.WriteLine(string.Join("\n",unsorted));
        }
    }
}