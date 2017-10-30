using System;

namespace HackerRank.Algorithms.Implementation
{
    public class DayOfTheProgrammer : IChallenge
    { 
        // https://www.hackerrank.com/challenges/day-of-the-programmer/problem
       
        static string solve(int year)
        {
            // Julian calendar
            if(year < 1918) {  
                return year % 4 == 0 ? $"12.09.{year}" : $"13.09.{year}";
            } 
            
            //Transition year
            if(year == 1918) return "26.09.1918"; 

            //Gregorian calendar
            return  (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) ? $"12.09.{year}" : $"13.09.{year}";
        }
        
        public void Run()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
        }
    }
}