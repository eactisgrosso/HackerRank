using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Sorting
{
    // https://www.hackerrank.com/challenges/quicksort1/problem
    public class Quicksort1 : IChallenge
    {
        static void partition(int[] ar) {
            var pivot = ar[0];
            var left = new List<int>(){pivot};
            var right = new List<int>();
            
            for(var i = 1; i < ar.Length; i++)
            {
                if (ar[i] < pivot) left.Insert(0,ar[i]);
                else if (ar[i] > pivot) right.Add(ar[i]);
                else left.Add(ar[i]);
            }

            left.AddRange(right);

            Console.WriteLine(string.Join(" ", left));
        }
        
        public void Run()
        {
            int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }

           partition(_ar);
        }
    }
}