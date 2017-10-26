using System;

namespace HackerRank.Algorithms.Warmup 
{
    public class PlusMinus : IChallenge
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

            double positives = 0, negatives = 0, zeroes = 0;
            foreach(var i in arr)
            {
                if(i > 0){
                    positives++;
                } else if (i < 0){
                    negatives++;
                } else {
                    zeroes++;
                }
            }

            Console.WriteLine(positives/n);
            Console.WriteLine(negatives/n);
            Console.WriteLine(zeroes/n);
        }
    }
}