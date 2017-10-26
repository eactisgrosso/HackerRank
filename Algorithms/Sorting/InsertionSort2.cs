using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting 
{
    public class InsertionSort2 : IChallenge
    {
        static void insertionSort(int[] ar) {
            int j, next;
            for (var i = 0; i < ar.Length - 1; i++)
            {
                j = i;
                next = ar[i + 1];
                while (j >= 0 && ar[j] > next)
                {
                    ar[j + 1] = ar[j];
                    j--;
                }
                ar[j + 1] = next;
                Console.WriteLine(string.Join(" ", ar));
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