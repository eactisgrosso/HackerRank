using System;
using System.Text;

namespace HackerRank.Algorithms.Warmup 
{
    public class TimeConversion : IChallenge
    {
        static string timeConversion(string s) 
        {
            var time = s.Split(':');
            byte hour = Byte.Parse(time[0]);

            if (hour == 12) hour = 0;
            if (time[2].EndsWith("PM")) hour +=12;

            return string.Format($"{hour:D2}{s.Substring(2,6)}");
        }
        
        public void Run()
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}