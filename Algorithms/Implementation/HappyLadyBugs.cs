using System;
using System.Linq;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/happy-ladybugs/problem
    public class HappyLadyBugs : IChallenge
    { 
        static bool CanAllLadyBugsBeHappy(string board)
        {
            var ocurrences = new int[26];
            var anyEmpty = false;
            var alreadyAHappyBug = true;
            for(var i = 0; i < board.Length; i++){
                var cell = board[i];
                if (cell == '_') {
                    anyEmpty = true;
                    continue;
                }
                
                if ((i == 0 || cell != board[i-1]) && (i == board.Length -1 || cell != board[i+1])) 
                    alreadyAHappyBug = false;

                ocurrences[board[i]-'A']++;
            }
                
            return (anyEmpty && ocurrences.All(count => count != 1)) || alreadyAHappyBug;
        }  

        public void Run()
        {
            int Q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < Q; a0++){
                Console.ReadLine();
                var board = Console.ReadLine();
                Console.WriteLine(CanAllLadyBugsBeHappy(board) ? "YES" : "NO");
            }
        }
    }
}