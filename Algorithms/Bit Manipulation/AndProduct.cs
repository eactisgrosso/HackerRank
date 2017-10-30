using System;
using HackerRank.Library;

namespace HackerRank.Algorithms.BitManipulation
{
    // https://www.hackerrank.com/challenges/and-product/problem
    public class AndProduct : IChallenge
    {
        public void Run()
        {
            var n = byte.Parse(Console.ReadLine());
            for(byte i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var a = long.Parse(input[0]);
                var b = long.Parse(input[1]);
                var xor = a ^ b; //diff bits
                var nextPowerOf2 = 1L;
                while(nextPowerOf2 <= xor) nextPowerOf2 <<= 1; //find the mask that zeros out the diff bits
                Console.WriteLine(a & ~(nextPowerOf2-1L)); 

                //Example:
                //
                // a 	            	=	106006  = 11001111000010110
                // b 	        	    = 	125297  = 11110100101110001
                // xor 	                =	30567 	= 00111011101100111
                // nextPowerOf2 	    = 	32768 	= 01000000000000000
                // nextPowerOf2-1       =   32767 	= 00111111111111111 
                // a&~(nextPowerOf2-1)  =	98304	= 11000000000000000
            }
        }

    }
}