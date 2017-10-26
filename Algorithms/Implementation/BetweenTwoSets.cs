using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    public class BetweenTwoSets : IChallenge
    {
        static int getTotalX(int[] a, int[] b) //Brute force approach, performant enough to pass the test cases
        {
            int counter = 0;
            for (var x = a[a.Length-1]; x <= b[0]; x++) {
                if (a.All(ai => x.IsDivisibleBy(ai)))
                    if (b.All(bi => bi.IsDivisibleBy(x))) counter++;
            }

            return counter;
        }

        static int getTotalX2(int[] a, int[] b) //Editorial approach
        {
            var multiple = 0;
            foreach(var i in b)
                multiple = multiple.GCD(i);

            var factor = 1;
            foreach(var i in a)
            {
                factor = factor.LCM(i);
                if (factor > multiple) return 0;
            }
        
            if (!multiple.IsDivisibleBy(factor)) return 0;

            int counter = 1;
            for (int i = factor; i < multiple; i++) {
                if (multiple.IsDivisibleBy(i) && i.IsDivisibleBy(factor)) 
                    counter++;
            }

            return counter;
        }

        public void Run()
        {
            Console.ReadLine();
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp,Int32.Parse);
            int total = getTotalX2(a, b);
            Console.WriteLine(total);
        }
    }
}
