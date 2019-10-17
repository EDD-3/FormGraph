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
            Point point = new Point(rnd.Next(),rnd.Next());
            mapCities.AddNode(txtNodeName.Text, point);
            lbxGraph.DataSource = mapCities.GetNodeName();
            cbxSource.DataSource = mapCities.GetNodeName();
            cbxDestination.DataSource = mapCities.GetNodeName();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string sourceName = cbxSource.SelectedItem.ToString();
            string destinationName = cbxDestination.SelectedItem.ToString();

            Node source = mapCities.GetNode(sourceName);
            Node destination = mapCities.GetNode(destinationName);

            source.AddConnection(destination);
            destination.AddConnection(source);



        }
    }
}
