using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting 
{
    public class InsertionSort1 : IChallenge
    {
        static void insertionSort(int[] ar) {
            var i = ar.Length - 1;
            var unsorted = ar[i];
            while (i>=0)
            {
                if (i > 0 && ar[i-1] > unsorted) {
                    ar[i] = ar[i-1];
                    Console.WriteLine(string.Join(" ", ar));
                } else {
                    ar[i] = unsorted;
                    Console.WriteLine(string.Join(" ", ar));
                    break;
                }
                i--;
            }
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

           insertionSort(_ar);
        }

    }
}