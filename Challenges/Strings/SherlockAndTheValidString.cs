using System;
using System.Linq;
using System.Collections.Generic;

namespace HackerRank.Challenges.Strings 
{

    public class SherlockAndTheValidString : IChallenge
    {
        const short MAX_LENGTH = 26;

        static string isValid(string s){
            int[] frequency = new int[26];

            for(var i = 0; i < s.Length; i++)
                frequency[s[i]-'a']++;
            
            int[,] ocurrences = new int[2,2];
            foreach(var o in frequency) {
                if (o == 0) continue;
                if (ocurrences[0,0] == o || ocurrences[0,0] == 0){
                    ocurrences[0,0] = o;
                    ocurrences[0,1]++;
                }else if (ocurrences[1,0] == o || ocurrences[1,0] == 0){
                    ocurrences[1,0] = o;
                    ocurrences[1,1]++;
                } else return "NO";
            }

            if (ocurrences[1,0] == 0) return "YES";
            
            if ((ocurrences[1,0] == 1 && ocurrences[1,1] == 1) ||  (ocurrences[0,0] == 1 && ocurrences[0,1] == 1)) return "YES";

            return (ocurrences[0,1] == 1 || ocurrences[1,1] == 1) && (Math.Abs(ocurrences[1,0] - ocurrences[0,0]) == 1) ?               "YES" : "NO";
        }
        public void Run()
        {
            string s = Console.ReadLine();
            string result = isValid(s);
            Console.WriteLine(result);
        }
    }
}