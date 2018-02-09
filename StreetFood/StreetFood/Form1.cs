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
using System.Web.Script.Serialization;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Newtonsoft.Json;

namespace StreetFood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter_1(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting values from inputs
            string city = "vancouver"; //cityBox.Text;
            string street = streetBox.Text;
            string zip = zipCodeBox.Text;

            //api
            WebRequest request = WebRequest.Create("http://data.streetfoodapp.com/1.1/schedule/" + city);
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string data = reader.ReadToEnd();

            List<Vendor> vendors = this.getVendorsFromApi(data);
            List<Vendor> todayVendors = this.getTodayVendors(vendors);

            reader.Close();
            dataStream.Close();
            response.Close();

            gMap.SetPositionByKeywords(city); //Position = this.getPointByCityName(city);
            List<Vendor> vendors = this.getVendorsFromApi(data);
            this.makeMarkers(vendors);
        }

        private List<Vendor> getTodayVendors(List<Vendor> vendors)
        {
            List<Vendor> todayVendors = new List<Vendor>();

            foreach (Vendor vendor in vendors)
            {
                if (vendor.opens.Any())
                {
                    foreach (Open open in vendor.opens)
                    {
                        if (open.isOpennedToday())
                        {
                            todayVendors.Add(vendor);
                        }
                    }
                }
            }

            return todayVendors;
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
            gMap.SetPositionByKeywords("new york");
            gMap.MinZoom = 4;
            gMap.MaxZoom = 24;
            gMap.Zoom = 11;
            gMap.AutoScroll = true;
            gMap.MarkersEnabled = true;
        }
     
        private List<Vendor> getVendorsFromApi(string data)
        {
            List<Vendor> vendors = new List<Vendor>();
            dynamic vendorsData = JsonConvert.DeserializeObject(data);
          
            foreach(var vendor in vendorsData["vendors"])
            {
                foreach (var vendorParams in vendor)
                {
                    List<Open> opens = new List<Open>();
                    List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

                    if(vendorParams["payment_methods"] != null)
                    {
                        foreach (var method in vendorParams["payment_methods"])
                        {
                            paymentMethods.Add(new PaymentMethod() { name = method });
                        }
                    }
                    
                    foreach (var open in vendorParams["open"])
                    {
                        opens.Add(new Open() {
                           start = (int)open["start"],
                           end = (int)open["end"],
                           display = open["display"],
                           latitude = (float)open["latitude"],
                           longitude = (float)open["longitude"]
                        });
                    }

                    vendors.Add(new Vendor() {
                        descriptionShort = vendorParams["description_short"],
                        identifier = vendorParams["identifier"],
                        name = vendorParams["name"],
                        region = vendorParams["region"],
                        url = vendorParams["url"],
                        phone = vendorParams["phone"],
                        email = vendorParams["email"],
                        twitter = vendorParams["twitter"],
                        facebook = vendorParams["facebook"],
                        instagram = vendorParams["instagram"],
                        description = vendorParams["description"],
                        rating = (int)vendorParams["rating"],
                        paymentMethods = paymentMethods,
                        opens = opens
                    });
                }
            }

            return vendors;
        }

        private PointLatLng getPointByCityName(string city) //TODO: should be removed
        {
            List<PointLatLng> points;
            GMapProviders.GoogleMap.GetPoints(city, out points);

            return points[0];
        }

        private void makeMarkers(List<Vendor> vendors)
        {
            Bitmap markerIcon = new Bitmap(Properties.Resources.foodtruck_icon);
            GMapOverlay markersOverlay = new GMapOverlay("vendorMarkers");

            GMarkerGoogle marker = new GMarkerGoogle(this.getPointByCityName("vancouver"), markerIcon);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = vendors[0].description;
            marker.ToolTip = new GMapBaloonToolTip(marker);
            marker.ToolTip.Fill = new SolidBrush(Color.GhostWhite);
            marker.ToolTip.Stroke = new Pen(Color.Gold);

            markersOverlay.Markers.Add(marker);
            gMap.Overlays.Add(markersOverlay);
          
        }
    }
}
