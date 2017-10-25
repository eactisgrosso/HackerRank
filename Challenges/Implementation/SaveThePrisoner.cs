using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Challenges.Implementation 
{
    public class SaveThePrisoner : IChallenge
    { 
        static int saveThePrisoner(int n, int m, int s){
                return ((m - 1) + (s - 1)) % n + 1;
        }

        public void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < t; a0++){
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int s = Convert.ToInt32(tokens_n[2]);
                int result = saveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
    }
}