using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FormGraph
{
    class Node
    {
        public List<Tuple<Node, double>> Connections { get; set; }
        public string Name { get; set; }
        public Point Coordinate { get; set; }

        public Node(string name, Point coordinate)
        {
            Name = name;
            Coordinate = coordinate;
            Connections = new List<Tuple<Node, double>>();
        }

        public void AddConnection(Node node)
        {
            double CatetA = Math.Abs(Coordinate.X - node.Coordinate.X);
            double CatetB = Math.Abs(Coordinate.Y - node.Coordinate.Y);

            double Distance = Math.Sqrt(Math.Pow(CatetA, 2) + Math.Pow(CatetB, 2));

            Tuple<Node, double> Connection = new Tuple<Node, double>(node, Distance);

            Connections.Add(Connection);
        }

        public double GetDistance(Node end)
        {
            foreach(Tuple<Node, double> t in Connections)
            {
                if (t.Item1 == end)
                {
                    return t.Item2;
                }
            }

            return 0;
        }


    }
}
