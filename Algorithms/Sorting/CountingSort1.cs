using System;

namespace HackerRank.Algorithms.Sorting
{
    public class CountingSort1 : IChallenge
    {
        // https://www.hackerrank.com/challenges/countingsort1/problem
        public void Run()
        {
            Console.ReadLine();
            var array = new int[100];
     
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            foreach(var i in input){
                array[i]++;
            }
               
            Console.WriteLine(string.Join(" ", array));
        }
    }
}