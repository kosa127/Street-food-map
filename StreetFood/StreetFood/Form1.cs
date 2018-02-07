using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace StreetFood
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting values from inputs
            string city = cityBox.Text;
            string street = streetBox.Text;
            string zip = zipCodeBox.Text;

            //api
            WebRequest request = WebRequest.Create("http://data.streetfoodapp.com/1.1/schedule/" + city);
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string data = reader.ReadToEnd();

            Console.WriteLine(data);
            
            reader.Close();
            dataStream.Close();
            response.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.initMap();
        }

        private void initMap()
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(42.75, -97.75);
            gMap.MinZoom = 0;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            gMap.AutoScroll = true;
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void groupBox1_Enter(object sender, EventArgs e) {}
        private void groupBox1_Enter_1(object sender, EventArgs e) {}

    }
}
