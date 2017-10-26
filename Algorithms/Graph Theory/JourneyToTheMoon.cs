using System;
using System.Linq;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.GraphTheory
{
    // https://www.hackerrank.com/challenges/journey-to-the-moon/problem
    public class JourneyToTheMoon : IChallenge
    {
        public void Run()
        {
            using (var reader = new System.IO.StreamReader("C:\\Development\\Input.txt"))
            {
                    var input = reader.ReadLine().Split(' ');
                    var n = int.Parse(input[0]);
                    
                    var astronauts = new Node[n];
                    for (var i = 0; i < n; i++) 
                        astronauts[i] = new Node(i);
                    
                    var p = int.Parse(input[1]);
                    for (var i = 0; i < p; i++) {
                        var pair = Array.ConvertAll(reader.ReadLine().Split(' '), int.Parse);
                        astronauts[pair[0]].Adjacent.AddLast(astronauts[pair[1]]);
                        astronauts[pair[1]].Adjacent.AddLast(astronauts[pair[0]]);
                    }

                    Console.WriteLine(AstronautsCombination(astronauts));    
            }
        }

        static long AstronautsCombination(Node[] astronauts)
        {
            var q = new Queue<Node>();
            var fellowsByCountry = new List<int>();
            var fellows = 0;
            Node astronaut;
            
            for (var i = 0; i < astronauts.Length; i++)
            {
                astronaut = astronauts[i];
                if (astronaut.HasBeenVisited) continue;

                astronaut.HasBeenVisited = true;
                fellows = 1;
                q.Enqueue(astronaut);
                while (q.Count > 0) 
                {
                    astronaut = q.Dequeue();
                    foreach(var fellow in astronaut.Adjacent)
                    {
                        if (!fellow.HasBeenVisited)
                        {
                            fellows ++;
                            fellow.HasBeenVisited = true;
                            q.Enqueue(fellow);
                        }
                    }
                };
                if (fellows > 0) fellowsByCountry.Add(fellows);
            }   

            var pairs = 0L;
            var remaining = astronauts.Length;
            foreach(var count in fellowsByCountry)
            {
                remaining -= count;
                pairs += count * remaining;
            }
            
            return pairs;
        }
    }
}