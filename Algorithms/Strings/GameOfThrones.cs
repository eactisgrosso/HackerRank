using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/game-of-thrones/problem
    public class GameOfThrones : IChallenge
    {
        static string gameOfThrones(string s){
            var palindrome = 0;
            foreach(var c in s) palindrome ^= 1 << c-'a'; //Toggle ith bit
            if (palindrome == 0 || palindrome.IsPowerOfTwo())
               return "YES";

            return "NO";    
        }

        public void Run()
        {
            string s = Console.ReadLine();
            string result = gameOfThrones(s);
            Console.WriteLine(result);
        }
    }
}