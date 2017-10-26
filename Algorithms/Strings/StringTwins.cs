using System;
using System.Linq;

namespace HackerRank.Algorithms.Strings 
{

    public class StringTwins: IChallenge 
    {
        const int MAX_LENGTH = 26;
        public void Run()
        {
            var results = Twins(new[] {"cdaba", "dcba"}, new[] {"abcda", "abcd"}); 
            foreach(var r in results){
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }

        string[] Twins(string[] a, string[] b) 
        {
            string[] result = new string[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if(i + 1 > b.Length){
                    result[i] = "No";
                }

                var hash_a = Hash(a[i]);
                var hash_b = Hash(b[i]);

                result[i] = hash_a.SequenceEqual(hash_b) ? "Yes" : "No";
            }

            return result;
        }

        int[] Hash(string str)
        {
            if (str.Length == 0) return new int[0];

            int[] hashEven = new int[MAX_LENGTH];
            int[] hashOdd = new int[MAX_LENGTH];
        
            for (int i=0; i<str.Length; i++)
            {
                var c = str[i];
                if (i%2 > 0){ 
                    hashOdd[c-'a']++;
                } else {
                    hashEven[c-'a']++;
                }
            }
            
            int[] result = new int[MAX_LENGTH * 2];
            hashEven.CopyTo(result, 0);
            hashOdd.CopyTo(result, hashEven.Length);

            return result;
        }
    }
}