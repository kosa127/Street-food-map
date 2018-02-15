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
        private List<Vendor> todayVendors;

        public MainForm()
        {
            InitializeComponent();
            this.initMap();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string city = cityBox.Text.ToLower();
            string data = this.getDataFromApi(city);

            if (data != "error")
            {
                List<Vendor> vendors = this.getVendorsFromApi(data);
                this.todayVendors = this.getTodayVendors(vendors);

                gMap.SetPositionByKeywords(city);
                gMap.Overlays.Clear();
                this.makeMarkers(todayVendors);
                gMap.ZoomAndCenterMarkers("vendorMarkers");
            }
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
                    string imageUrl = "http://bcmd.bt/wp-content/themes/BcmdTheme/images/no-image.png";

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

                    if (vendorParams["images"] != null)
                    {
                        if (vendorParams["images"]["header"] != null)
                        {
                            imageUrl = vendorParams["images"]["header"][0];
                        }
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
                        imageUrl = imageUrl,
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
                    SolidBrush fillColor = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#26262c"));
                    Pen borderColor = new Pen(Color.Gold);
                    overlay.Markers.Add(marker);

                    marker.ToolTipMode = MarkerTooltipMode.Never;
                    marker.ToolTipText = vendor.description;
                    marker.ToolTip = new VendorTooltip(marker, vendor);
                    marker.ToolTip.Foreground = new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#16EFC0"));
                    marker.ToolTip.Fill = fillColor;
                    marker.ToolTip.Stroke = borderColor;

                    vendor.marker = marker;
                }
            }
        }

        private string getDataFromApi(string city)
        {
            try
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
            } catch (Exception e)
            {
                MessageBox.Show("Make sure that you did not made any typo.", "No food trucks found :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return "error";
            }
            
        }

        private void gMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Vendor clickedVendor = this.getVendorByMarker(this.todayVendors, item);

            if (clickedVendor != null)
            {
                this.setResultPanelContent(clickedVendor);
            }
            
            if (currentlySelectedMarker != null)
            {
                currentlySelectedMarker.ToolTipMode = MarkerTooltipMode.Never;
            }

            if (currentlySelectedMarker == item)
            {
                resultGroupBox.Visible = false;
                imageBox.Visible = false;
                currentlySelectedMarker.ToolTipMode = MarkerTooltipMode.Never;
                currentlySelectedMarker = null;
            }
            else
            {
                currentlySelectedMarker = item;
                currentlySelectedMarker.ToolTipMode = MarkerTooltipMode.Always;
            }
        }

        private Vendor getVendorByMarker(List<Vendor> cachedVendors, GMapMarker marker)
        {
            foreach (Vendor vendor in cachedVendors)
            {
                if (vendor.marker == marker)
                {
                    return vendor;
                }
            }

            return null;
        }

        private void nightModeBar_Click(object sender, EventArgs e)
        {
            nightModeBar.Step = nightModeBar.Value == 0 ? 1 : -1;
            nightModeBar.PerformStep();
            gMap.NegativeMode = !gMap.NegativeMode;
        }

        private void facebookIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/" + (string)facebookIcon.Tag);
        }

        private void instagramIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/" + (string)instagramIcon.Tag);
        }

        private void twitterIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/" + (string)twitterIcon.Tag);
        }

        private void setResultPanelContent(Vendor vendor)
        {
            resultGroupBox.Visible = true;

            imageBox.ImageLocation = vendor.imageUrl;
            imageBox.Visible = true;

            nameLabel.Text = "Name: " + vendor.name;
            descriptionLabel.Text = "Description: " + vendor.description;
            paymentMethodsLabel.Text = "Payments methods: " + vendor.getReadablePaymentMethods();

            this.setSocialMedia(vendor);
            
        }
        
        private void setSocialMedia(Vendor vendor)
        {
            if (vendor.facebook != null)
            {
                facebookIcon.Visible = true;
                facebookIcon.Tag = vendor.facebook;
            }
            else
            {
                facebookIcon.Visible = false;
            }

            if (vendor.instagram != null)
            {
                instagramIcon.Visible = true;
                instagramIcon.Tag = vendor.instagram;
            }
            else
            {
                instagramIcon.Visible = false;
            }

            if (vendor.twitter != null)
            {
                twitterIcon.Visible = true;
                twitterIcon.Tag = vendor.twitter;
            }
            else
            {
                twitterIcon.Visible = false;
            }

        }
    }
}