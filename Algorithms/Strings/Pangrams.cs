using System;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/pangrams/problem
    public class Pangrams : IChallenge
    {
        static readonly int EVERY_LETTER = 67108863;
        static readonly byte UPPER_DIFF = 32; 
        public void Run()
        {
            var s = Console.ReadLine();
            int letterMap = 0;
            foreach(var c in s) {
                if(Char.IsLetter(c))
                    letterMap |= 1 << c+(Char.IsUpper(c) ? UPPER_DIFF : 0)-'a';
                if (letterMap == EVERY_LETTER) break;
            }
            Console.WriteLine(letterMap == EVERY_LETTER ? "pangram" : "not pangram");
        }
    }
}