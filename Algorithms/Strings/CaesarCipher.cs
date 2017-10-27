using System;
using System.Linq;

namespace HackerRank.Algorithms.Strings
{
    // https://www.hackerrank.com/challenges/caesar-cipher-1/problem
    public class CaesarCipher : IChallenge
    {
        public void Run()
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            var encrypted = new System.Text.StringBuilder();
            int rotated;
            foreach(var c in s)
            {
                if (Char.IsLetter(c))
                {
                    rotated = c + k;
                    while((Char.IsUpper(c) && rotated > 90) || rotated > 122){
                        rotated -= 26;
                    }
                    encrypted.Append((char)rotated);
                }else{
                    encrypted.Append(c);
                }
            }
            Console.WriteLine(encrypted);
        }
    }
}