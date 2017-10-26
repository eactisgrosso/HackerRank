using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation 
{
    public class AppleAndOrange : IChallenge
    { 
       
        public void Run()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            Console.ReadLine();
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apples = Array.ConvertAll(apple_temp,Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] oranges = Array.ConvertAll(orange_temp,Int32.Parse);

            var applecount = 0;
            foreach(var apple in apples){
                var d = a + apple;
                if (d >= s && d <=t) applecount++;
            }
                
            var orangecount = 0;
            foreach(var orange in oranges){
                var d = b + orange;
                if (d >= s && d <=t) orangecount++;
            }
             
            Console.WriteLine(applecount);
            Console.WriteLine(orangecount);
        }
    }
}