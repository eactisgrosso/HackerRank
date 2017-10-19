using System;

namespace HackerRank.Library
{
    public static class IntExtensions
    {
        public static int FloorLog2(this int i){
            int result = 0;
            while (i >= 1)
            {
                result++;
                i = i / 2;
            }
            return result;
        }
    }
}