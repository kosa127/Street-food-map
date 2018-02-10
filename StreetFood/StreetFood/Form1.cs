using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using StreetFood.models;

namespace StreetFood
{
    public partial class MainForm : Form
    {
        public GMapMarker currentlySelectedMarker;

        public MainForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string city = "vancouver"; //cityBox.Text;
            string data = this.getDataFromApi(city);

            List<Vendor> vendors = this.getVendorsFromApi(data);
            List<Vendor> todayVendors = this.getTodayVendors(vendors);

            gMap.SetPositionByKeywords(city);
            this.makeMarkers(todayVendors);
            gMap.ZoomAndCenterMarkers("vendorMarkers");
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
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.SetPositionByKeywords("new york");
            gMap.ShowCenter = false;
        }

        private List<Vendor> getVendorsFromApi(string data)
        {
            List<Vendor> vendors = new List<Vendor>();
            dynamic vendorsData = JsonConvert.DeserializeObject(data);

            foreach (var vendor in vendorsData["vendors"])
            {
                foreach (var vendorParams in vendor)
                {
                    List<Open> opens = new List<Open>();
                    List<PaymentMethod> paymentMethods = new List<PaymentMethod>();

                    if (vendorParams["payment_methods"] != null)
                    {
                        foreach (var method in vendorParams["payment_methods"])
                        {
                            paymentMethods.Add(new PaymentMethod() { name = method });
                        }
                    }

                    foreach (var open in vendorParams["open"])
                    {
                        opens.Add(new Open()
                        {
                            start = (int)open["start"],
                            end = (int)open["end"],
                            display = open["display"],
                            latitude = (float)open["latitude"],
                            longitude = (float)open["longitude"]
                        });
                    }

                    vendors.Add(new Vendor()
                    {
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

        private void makeMarkers(List<Vendor> vendors)
        {
            Bitmap markerIcon = new Bitmap(Properties.Resources.foodtruck_icon);
            GMapOverlay markersOverlay = new GMapOverlay("vendorMarkers");

            foreach (Vendor vendor in vendors)
            {
                this.setMarkerIfOpened(vendor, markerIcon, markersOverlay);
            }

            gMap.Overlays.Add(markersOverlay);
        }

        private void setMarkerIfOpened(Vendor vendor, Bitmap icon, GMapOverlay overlay)
        {
            foreach (Open open in vendor.opens)
            {
                if (open.isOpennedToday())
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(open.latitude, open.longitude), icon);
                    SolidBrush fillColor = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#00110D"));
                    Pen borderColor = new Pen(Color.Gold);
                    overlay.Markers.Add(marker);

                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTipText = "text";
                    marker.ToolTip = new VendorTooltip(marker, vendor);
                    marker.ToolTip.Foreground = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#16EFC0"));
                    marker.ToolTip.Foreground = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#16EFC0"));
                    marker.ToolTip.Fill = fillColor;
                    marker.ToolTip.Stroke = borderColor;
                }
            }
        }

        private string getDataFromApi(string city)
        {
            WebRequest request = WebRequest.Create("http://data.streetfoodapp.com/1.1/schedule/" + city);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string data = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return data;
        }

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(currentlySelectedMarker != null)
            {
                currentlySelectedMarker.ToolTipMode = MarkerTooltipMode.Never;
            }
            currentlySelectedMarker = item;
            item.ToolTipMode = MarkerTooltipMode.Always;
        }

        private void nightModeBar_Click(object sender, EventArgs e)
        {
            nightModeBar.Step = nightModeBar.Value == 0 ? 1 : -1;
            nightModeBar.PerformStep();
            gMap.NegativeMode = !gMap.NegativeMode;
        }
    }
}