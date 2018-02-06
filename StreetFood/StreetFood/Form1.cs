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
using CefSharp;
using CefSharp.WinForms;

namespace StreetFood
{
    public partial class Form1 : Form
    {

        public ChromiumWebBrowser chromeBrowser;

        public Form1()
        {
            InitializeComponent();
            this.initializeChromeBrowser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting values from inputs
            String city = cityBox.Text;
            String street = streetBox.Text;
            String zip = zipCodeBox.Text;
        }
        private void Form1_Load(object sender, EventArgs e) {}
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label2_Click(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void groupBox1_Enter(object sender, EventArgs e) {}
        private void groupBox1_Enter_1(object sender, EventArgs e) {}

        private void initializeChromeBrowser()
        {
            //setting up path to HTML file with map
            String mapLocalPath = String.Format("file:///{0}/map.html", Directory.GetCurrentDirectory());

            //setting up browser settings
            CefSettings browserSettings = new CefSettings();
            browserSettings.RemoteDebuggingPort = 8088;
            Cef.Initialize(browserSettings);

            //initializing browser compontent
            chromeBrowser = new ChromiumWebBrowser(mapLocalPath);
            chromeBrowser.Dock = DockStyle.Fill;

            //add ready browser to component
            splitContainer1.Panel2.Controls.Add(chromeBrowser);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
