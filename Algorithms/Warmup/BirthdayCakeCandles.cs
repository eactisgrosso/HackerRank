using System;

namespace HackerRank.Algorithms.Warmup 
{
    // https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    public class BirthdayCakeCandles : IChallenge
    {
        static int birthdayCakeCandles(int n, int[] ar) {
            int max = 0, counter = 0;
            for(var i = 0; i < n; i++)
            {
                if (ar[i] > max){
                    max = ar[i];
                    counter = 1;    
                }else if(ar[i] == max){
                    counter++;
                }
            }    
            return counter;
        }
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}