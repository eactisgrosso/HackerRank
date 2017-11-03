using System;

namespace HackerRank.Algorithms.Implementation
{
    // https://www.hackerrank.com/challenges/bomber-man/problem
    public class TheBombermanGame : IChallenge
    { 
        public void Run()
        {
            var firstLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var rows = firstLine[0];
            var cols = firstLine[1];
            var seconds = firstLine[2];
            var grid = new int[rows,cols];
            for(var i = 0; i < rows; i++)
            {
                var line = Console.ReadLine();
                for(var j = 0; j < line.Length; j++)
                    grid[i,j] = line[j] == '.' ? -1 : 0;
            }

            seconds = seconds > 3 ? (seconds - 2) % 4 + 2: seconds;
            for(var s = 1; s <= seconds; s++)
            {
                for(var row = 0; row < rows; row++)
                for(var col = 0; col < cols; col++)
                {
                    if (grid[row,col] > -1) grid[row,col]++;
                    if (s % 2 == 0)
                    {
                        if (grid[row,col] == -1) grid[row,col] = 0; //plant
                    }
                    else
                    {
                        if (grid[row,col] == 3) //detonate
                        {
                            grid[row,col] = -1; 
                            if (row > 0 && grid[row-1,col] < 2) grid[row-1,col] = -1;
                            if (row < rows - 1 && grid[row+1,col] < 2) grid[row+1,col] = -1;
                            if (col > 0 && grid[row,col-1] < 2) grid[row,col-1] = -1; 
                            if (col < cols - 1 && grid[row,col+1] < 2) grid[row,col+1] = -1; 
                        }
                    }
                }
            }

            for(var row = 0; row < rows; row++)
            {
                for(var col = 0; col < cols; col++) {
                    Console.Write(grid[row,col] == -1 ? '.' : 'O');
                }
                Console.WriteLine();
            }
        }
    }
}