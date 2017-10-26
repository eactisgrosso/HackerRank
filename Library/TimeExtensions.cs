using System;
using System.Collections.Generic;

namespace HackerRank.Library
{
    public static class TimeExtensions
    {
        public static string ToWords(this TimeSpan t) 
        {
            switch(t.Minutes)
            {
                case 0:
                    return $"{t.Hours.ToWords()} o' clock";
                case 1:  
                    return $"one minute past {t.Hours.ToWords()}";
                case 15:
                    return $"quarter past {t.Hours.ToWords()}";
                case 30:
                    return $"half past {t.Hours.ToWords()}";
                case 45:
                    return $"quarter to {(t.Hours + 1).ToWords()}";
                case 59:
                    return $"one minute to {(t.Hours + 1).ToWords()}";
            }

            if (t.Minutes < 30)
                return $"{t.Minutes.ToWords()} minutes past {t.Hours.ToWords()}";
            else
                return $"{(60 - t.Minutes).ToWords()} minutes to {(t.Hours + 1).ToWords()}";
        }
    }
}