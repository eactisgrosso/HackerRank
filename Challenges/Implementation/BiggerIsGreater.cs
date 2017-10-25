using System;
using System.Collections.Generic;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Challenges.Implementation 
{
    public class BiggerIsGreater : IChallenge
    { 
        public void Run()
        {
           var n = int.Parse(Console.ReadLine());
           for(var i = 0; i < n; i++)
           {
               var input = Console.ReadLine();
               var output = LexicographicalPermutation(input);
               if (input == output){
                   Console.WriteLine("no answer");
               }else{
                   Console.WriteLine(output);
               }
           }
        }

        public static string LexicographicalPermutation(string input) {
            var array = input.ToCharArray();

            // Find non-increasing suffix
            int i = array.Length - 1;
            while (i > 0 && array[i - 1] >= array[i])
                i--;
            if (i <= 0)
                return input;
            
            // Find successor to pivot
            int j = array.Length - 1;
            while (array[j] <= array[i - 1])
                j--;
            var temp = array[i - 1];
            array[i - 1] = array[j];
            array[j] = temp;
            
            // Reverse suffix
            j = array.Length - 1;
            while (i < j) {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }

            return new string(array);
        }
    }
}