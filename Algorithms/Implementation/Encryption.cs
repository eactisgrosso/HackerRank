using System;
using System.Linq;
using HackerRank.Library;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/encryption/problem
    public class Encryption : IChallenge
    { 
        public void Run()
        {
            var input =  Console.ReadLine();
            input = input.Replace(" ", string.Empty);

            var square = Math.Sqrt(input.Length);
            var rows = (int)Math.Floor(square);
            var cols = (int)Math.Ceiling(square);
          
            if (rows * cols < input.Length)
                rows++;

            var grid = new char[rows,cols];
            int row = 0, col = 0;
            for(var i = 0; i < input.Length; i++)
            {
                grid[row,col] = input[i];
                col++;
                if (col > cols -1)
                {
                    col = 0; 
                    row++;
                } 
            }

            for(col = 0; col < cols; col++)
            {
                var line = new System.Text.StringBuilder();
                for(row = 0; row < rows; row++) {
                    if (grid[row,col] > 0)
                        line.Append(grid[row,col]);
                }
                Console.Write($"{line} ");    
            }
        }
    }
}