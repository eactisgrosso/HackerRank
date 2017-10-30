using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/funny-string/problem
    public class FunnyString : IChallenge
    {
        static string funnyString(string s)
        {
            var end = s.Length;
            var middle = (end/2)+1;
            
            for(int i = 1; i < middle; i++)
            {
                int left = Math.Abs(s[i] - s[i-1]);
                int right = Math.Abs(s[end-i-1] - s[end-i]);
                if( left != right) return "Not Funny";
            }

            return "Funny";
        }

        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s = Console.ReadLine();
                string result = funnyString(s);
                Console.WriteLine(result);
            }
        }
    }
}