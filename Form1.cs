using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGraph
{
    public partial class frmElViajero : Form
    {

        Graph mapCities = new Graph();
        double distance = 0;
        public frmElViajero()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (mapCities.Nodes.Count < 2)
            {
                MessageBox.Show("Debes tener al menos 2 Nodeos para poder conectar");
            }
            else if( cbxDestination.SelectedIndex == cbxSource.SelectedIndex)
            {
                MessageBox.Show("No puedes conectar el mismo nodo");

            }
            else
            {
                
                Node source = mapCities.Nodes[cbxSource.SelectedIndex];
                Node destination = mapCities.Nodes[cbxDestination.SelectedIndex];
                if (! source.Connections.Any( item => item.Item1.Name == destination.Name ) )
                {
                    mapCities.ConnectNodes(source, destination);
                    pnlGraph.Refresh();
                    MessageBox.Show("Nodos conectados correctamente");
                }

            }

        }

        private void BtnGetDistance_Click(object sender, EventArgs e)
        {
            if (mapCities.Nodes.Count < 2)
            {
                MessageBox.Show("Debes tener al menos 2 Nodos para poder buscar un camino");
            }
            else if (cbxStart.SelectedIndex == cbxEnd.SelectedIndex)
            {
                MessageBox.Show("Escoja un nodo diferente del comienzo como su final");
            }
            else
            {
                Node start = mapCities.Nodes[cbxStart.SelectedIndex];
                Node destination = mapCities.Nodes[cbxEnd.SelectedIndex];
                mapCities.AuxGetShorterWay(start, destination);

                List<Node> ways = mapCities.visited;
                pnlGraph.Refresh();
                if (ways.Count > 1)
                {
                    List<string> sauce = new List<string>();
                    MessageBox.Show("Camino encontrado");
                    foreach(Node way in ways)
                    {
                        if (!(way is null))
                        {
                            sauce.Add(way.Name);
                        }
                    }

                    for (int i = 0; i < ways.Count-1 ; i++)
                    {
                        distance += ways[i].GetDistance(ways[i + 1]);
                    }

                    lbxPath.DataSource = sauce;
                    lblDistanceIs.Text += " " + distance.ToString();
                    pnlGraph.Refresh();
                }
                else
                {
                    MessageBox.Show("Camino no encontrado");
                }

            }

        }

        private void PnlGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtNodeName.Text != string.Empty)
            {
                Node n = new Node(txtNodeName.Text, e.Location);

                if (!mapCities.Nodes.Any( node => node.Name == n.Name))
                {
                    PictureBox pbx = new PictureBox();
                    pbx.Image = Properties.Resources.city;
                    pbx.Width = 16;
                    pbx.Height = 16;
                    pbx.Location = n.Coordinate;
                    pnlGraph.Controls.Add(pbx);
                    Label lbl = new Label();
                    lbl.Text = n.Name;
                    lbl.Location = new Point(pbx.Location.X - 5, pbx.Location.Y + pbx.Height);
                    pnlGraph.Controls.Add(lbl);
                    mapCities.AddNode(n);
                    RefreshComboBox();
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre distinto");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un nombre para el nodo");
            }

        }

        private void PnlGraph_Paint(object sender, PaintEventArgs e)
        {
            foreach (Tuple<Point, Point, Color> v in mapCities.Vertices)
            {
                Pen pen = new Pen(v.Item3);
                e.Graphics.DrawLine(pen, v.Item1, v.Item2);
            } 
        }

        private void RefreshComboBox()
        {
            cbxSource.DataSource = mapCities.GetNodeName();
            cbxDestination.DataSource = mapCities.GetNodeName();
            cbxStart.DataSource = mapCities.GetNodeName();
            cbxEnd.DataSource = mapCities.GetNodeName();
        }

        private void FrmElViajero_Load(object sender, EventArgs e)
        {
            
        }
    }
}
