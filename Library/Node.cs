using System.Collections.Generic;

namespace HackerRank.Library
{
    public class Node {
        public int Id {get; set;}
        public LinkedList<Node> Adjacent {get;private set;}

        public bool HasBeenVisited {get; set;}

        public Node(int id){
            Id = id;
            Adjacent = new LinkedList<Node>();
        }
    }
}
