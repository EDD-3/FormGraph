using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormGraph
{
    class Graph
    {

        List<Node> Nodes;

        public Graph()
        {
            Nodes = new List<Node>();
        }
        //Codigo que un nodo al grafo(lista)
        public void AddNode(string Name, Point Coordinate) => Nodes.Add(new Node(Name, Coordinate));

        public List<string> GetNodeName()
        {
            List<string> list = new List<string>();

            Nodes.ForEach( (Node n) => list.Add(n.Name));

            //foreach(Node node in Nodes) list.Add(node.Name);
            
            return list;
        }

        public void GetShorterWay(Node Node1, Node Node2)
        {
            //El bromas
        }

        public Node GetNode(string name) => Nodes.Find( (Node n) => n.Name == name);

       /** public Node GetNode(string name)
        {
            foreach (Node n in Nodes)
            {
               if (n.Name == name)
                {
                    return n;
                } 
            }
        }**/
    }
}
