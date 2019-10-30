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
        Random rnd = new Random();

        public frmElViajero()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            int x = rnd.Next(1, 1000);
            int y = rnd.Next(2, 1001);
            Point point = new Point(x, y);
            mapCities.AddNode(txtNodeName.Text, point);
            lbxGraph.DataSource = mapCities.GetNodeName();
            cbxSource.DataSource = mapCities.GetNodeName();
            cbxDestination.DataSource = mapCities.GetNodeName();
            cbxStart.DataSource = mapCities.GetNodeName();
            cbxEnd.DataSource = mapCities.GetNodeName();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string sourceName = cbxSource.SelectedItem.ToString();
            string destinationName = cbxDestination.SelectedItem.ToString();

            //MessageBox.Show(sourceName + " " + destinationName);

            Node source = mapCities.GetNode(sourceName);
            Node destination = mapCities.GetNode(destinationName);

            MessageBox.Show(source.Coordinate + " " + destination.Coordinate);


            source.AddConnection(destination);
            destination.AddConnection(source);

        }

        private void BtnGetDistance_Click(object sender, EventArgs e)
        {
            string startName = cbxStart.SelectedItem.ToString();
            string endName = cbxEnd.SelectedItem.ToString();

            Node start = mapCities.GetNode(startName);
            Node end = mapCities.GetNode(endName);

            string distance = start.GetDistance(end).ToString();



            lblDistance.Text = distance;
        }
    }
}
