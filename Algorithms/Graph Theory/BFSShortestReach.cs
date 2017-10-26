using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using HackerRank.Library;

namespace HackerRank.Algorithms.GraphTheory 
{
    public class BFSShortestReach : IChallenge
    {
        const short EDGE_DISTANCE = 6;

        public void Run()
        {
             int q = int.Parse(Console.ReadLine());

            for (int a0 = 0; a0 < q; a0++) {
                var input = Console.ReadLine().Split(' ');
                var n = short.Parse(input[0]);
                var m = int.Parse(input[1]);

                Node[] nodes = new Node[n];
                for (short i = 0; i < n; i++) {
                    nodes[i] = new Node(i);
                }

                for (int i = 0; i < m; i++) {
                    input = Console.ReadLine().Split(' ');
                    var u = (short)(short.Parse(input[0]) - 1);
                    var v = (short)(short.Parse(input[1]) - 1);

                    nodes[u].Adjacent.AddLast(nodes[v]);
                    nodes[v].Adjacent.AddLast(nodes[u]);
                }

                var s = (short)(short.Parse(Console.ReadLine()) - 1);
                var distances = Distances(s, nodes);

                Console.WriteLine(string.Join(" ", distances.Where(d => d != 0)));
            }
        }

        short[] Distances(short s, Node[] nodes) 
        {
            var distance = new short[nodes.Length];
            for(var i = 0; i < distance.Length; i++)
                distance[i] = -1;
            distance[s] = 0;

            var q = new Queue<Node>();
            var root = nodes[s];
            root.Visited = true;
            q.Enqueue(root);
            while (q.Count > 0) {
                Node node = q.Dequeue();
                foreach(var edge in node.Adjacent){
                    if (!edge.Visited){
                        edge.Visited = true;
                        q.Enqueue(edge);
                        distance[edge.Id] = (short)(distance[node.Id] + EDGE_DISTANCE);
                    }
                }
            };
            
            return distance;
        }

        class Node {
            public short Id {get; set;}
            public LinkedList<Node> Adjacent {get;private set;}

            public bool Visited {get; set;}

            public Node(short id){
                Id = id;
                Adjacent = new LinkedList<Node>();
            }
        }
    }
}