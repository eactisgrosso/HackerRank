using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation 
{
    public class FindDigits : IChallenge
    {
        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < t; a0++){
                int n = Convert.ToInt32(Console.ReadLine());
                var digits = n.Digits();
                var counter = 0;
                foreach(var digit in digits){
                    if (digit != 0 && n%digit == 0)
                        counter++;
                }
                Console.WriteLine(counter);
            }
        }
    }
}