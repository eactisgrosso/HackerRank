using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/mars-exploration/problem
    public class MarsExploration : IChallenge
    {
        public void Run()
        {
            string s = Console.ReadLine();
            var counter = 0;
            for(var i = 0; i < s.Length; i +=3)
            {
                var sos = s.Substring(i, 3);
                if (sos[0] != 'S') counter++;
                if (sos[1] != 'O') counter++;
                if (sos[2] != 'S') counter++;
            }
            Console.WriteLine(counter);
        }
    }
}