using System;
using System.Collections.Generic;

namespace HackerRank.Challenges.Strings 
{
    public class SuperReducedString : IChallenge
    {
        static string super_reduced_string(string s){
            var i = 0;
            while(true){
                if (i >= s.Length-1) break;
                if (s[i] == s[i+1]){
                    s = s.Remove(i,2);
                    if (i > 0)i--;
                }
                else i++;
            }
      
            if (string.IsNullOrEmpty(s)) return "Empty String";
            
            return s;
        }

        public void Run()
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }
    }
}