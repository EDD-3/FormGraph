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

        public List<Node> Nodes;
        public List<Tuple<Point, Point, Color>> Vertices;
        public List<Node> visited;
    


        public Graph()
        {
            Nodes = new List<Node>();
            Vertices = new List<Tuple<Point, Point, Color>>();
        }

        public void AddNode(Node n) => Nodes.Add(n);

        public Node GetNode(string name) => Nodes.Find((Node n) => n.Name == name);

        private void GetIndex(Node n1, Node n2,int j)
        {
           Tuple<int,bool> tuple = GetIndexOfEdge(n1, n2);

            if (tuple.Item2)
            {
                int i = tuple.Item1;
                Vertices[i] = new Tuple<Point, Point, Color>(Vertices[i].Item1, Vertices[i].Item2, Color.Red);
            }
            else
            {
                Vertices[j] = new Tuple<Point, Point, Color>(Vertices[j].Item1, Vertices[j].Item2, Color.Black);
            }

           /* for (int i = 0; i < Vertices.Count; i++)
            {
                if (n1.Coordinate == Vertices[i].Item1 && n2.Coordinate == Vertices[i].Item2)
                {
                    Vertices[i] = new Tuple<Point, Point, Color>(Vertices[i].Item1, Vertices[i].Item2, Color.Red);
                    
                }
                else if (n1.Coordinate == Vertices[i].Item2 && n2.Coordinate == Vertices[i].Item1)
                {
                    Vertices[i] = new Tuple<Point, Point, Color>(Vertices[i].Item1, Vertices[i].Item2,Color.Red);
                    
                }
                else
                {
                    Vertices[i] = new Tuple<Point, Point, Color>(Vertices[i].Item1, Vertices[i].Item2, Color.Blue);
                    
                }
            } */
        }
        private void ColorTheWay(List<Node> bestWay, int i = 0)
        {
            if ( i == bestWay.Count-1)
            {
                return;
            }
            else
            {
                GetIndex(bestWay[i], bestWay[i + 1],i);
                i++;
                ColorTheWay(bestWay, i);
            }
        }

        public List<string> GetNodeName()
        {
            List<string> list = new List<string>();

            foreach (Node node in Nodes)
            {
                list.Add(node.Name);
            }

            return list;
        }

        public void ConnectNodes(Node a, Node b)
        {
            a.AddConnection(b);
            b.AddConnection(a);
            Vertices.Add(new Tuple<Point, Point, Color>(a.Coordinate, b.Coordinate, Color.Black));
        }

        public void AuxGetShorterWay(Node start, Node end)
        {
           visited = new List<Node>();
           ColorTheWay(GetShorterWay(start, end));
        }

        private List<Node> GetShorterWay(Node start, Node end)
        {
            visited.Add(start);
            if (start is null)
            {
                return visited;
            }

            if (start.Name == end.Name)
            {
                return visited;
            }

            Node nextNode = GetCloserNode(start.Connections, visited, end);
            return GetShorterWay(nextNode, end);


        }

        public Node GetCloserNode(List<Tuple<Node, double>> connections, List<Node> visited, Node end)
        {

            if (connections.Any(item => item.Item1.Name == end.Name))
            {
                return end;
            }

            Node bestNode = null;
            double bestDistance = 10000000000;

            foreach (Tuple<Node, double> way in connections)
            {
                double distance = Math.Abs(way.Item1.Coordinate.X - end.Coordinate.X) +
                                    Math.Abs(way.Item1.Coordinate.Y - end.Coordinate.Y);

                bool isThereABetterOne = !(visited.Any(item => item.Name == way.Item1.Name)  && (distance < bestDistance));

                if (isThereABetterOne)
                {
                    bestNode = way.Item1;
                    bestDistance = distance;
                }
            }

            return bestNode;

        }


        public Tuple<int,bool> GetIndexOfEdge(Node n1, Node n2)
        {
            
            

            if(Vertices.Any(tuple => tuple.Item1 == n1.Coordinate && tuple.Item2 == n2.Coordinate))
            {
                int index = Vertices.FindIndex(tuple => tuple.Item1 == n1.Coordinate && tuple.Item2 == n2.Coordinate);
                return new Tuple<int, bool>(index, true);
            }

            if(Vertices.Any(tuple => tuple.Item1 == n2.Coordinate && tuple.Item2 == n1.Coordinate))
            {
                int index = Vertices.FindIndex(tuple => tuple.Item1 == n2.Coordinate && tuple.Item2 == n1.Coordinate);
                return new Tuple<int, bool>(index, true);

            }

            
            return new Tuple<int, bool>(0, false);
        }

    }
}

