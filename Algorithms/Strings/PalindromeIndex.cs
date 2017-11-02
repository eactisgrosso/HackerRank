using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/palindrome-index/problem
    public class PalindromeIndex : IChallenge
    {
        static int palindromeIndex(string s)
        {
            for(int i = 0, j = s.Length-1; i < j; ++i, --j)
            {
                if (s[i] != s[j])
                {
                    if (s.Substring(i+1, j-i).IsPalindrome()) return i;
                    else return j;
                }
            }

            return -1;
        }

        public void Run()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++){
                string s = Console.ReadLine();
                int result = palindromeIndex(s);
                Console.WriteLine(result);
            }
        }
    }
}