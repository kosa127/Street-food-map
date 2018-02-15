using System.Drawing;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;
using System.Drawing.Drawing2D;

namespace StreetFood.models
{
    class VendorTooltip : GMapBaloonToolTip
    {
        private Vendor vendor;
        public VendorTooltip(GMapMarker marker, Vendor vendor) : base(marker)
        {
            Fill = Brushes.Yellow;
            this.vendor = vendor;
        }

        public override void OnRender(Graphics g)
        {
            Rectangle rect = new Rectangle(Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y - 100, 250, 100);
            Rectangle name = new Rectangle(Marker.ToolTipPosition.X + 25, Marker.ToolTipPosition.Y - 130, 250, 100);
            Rectangle rating = new Rectangle(Marker.ToolTipPosition.X + 25, Marker.ToolTipPosition.Y - 100, 240, 20);
            Rectangle open = new Rectangle(Marker.ToolTipPosition.X + 25, Marker.ToolTipPosition.Y - 70, 240, 20);

            rect.Offset(Offset.X, Offset.Y);

            Open openVendor = this.vendor.openToday();
            
            using (GraphicsPath objGP = new GraphicsPath())
            {
                objGP.AddLine(rect.X + 2 * Radius, rect.Y + rect.Height, rect.X + Radius, rect.Y + rect.Height + Radius);
                objGP.AddLine(rect.X + Radius, rect.Y + rect.Height + Radius, rect.X + Radius, rect.Y + rect.Height);

                objGP.AddArc(rect.X, rect.Y + rect.Height - (Radius * 2), Radius * 2, Radius * 2, 90, 90);
                objGP.AddLine(rect.X, rect.Y + rect.Height - (Radius * 2), rect.X, rect.Y + Radius);
                objGP.AddArc(rect.X, rect.Y, Radius * 2, Radius * 2, 180, 90);
                objGP.AddLine(rect.X + Radius, rect.Y, rect.X + rect.Width - (Radius * 2), rect.Y);
                objGP.AddArc(rect.X + rect.Width - (Radius * 2), rect.Y, Radius * 2, Radius * 2, 270, 90);
                objGP.AddLine(rect.X + rect.Width, rect.Y + Radius, rect.X + rect.Width, rect.Y + rect.Height - (Radius * 2));
                objGP.AddArc(rect.X + rect.Width - (Radius * 2), rect.Y + rect.Height - (Radius * 2), Radius * 2, Radius * 2, 0, 90); // Corner

                objGP.CloseFigure();

                g.FillPath(Fill, objGP);
                //g.DrawPath(Stroke, objGP);
            }

#if !PocketPC

            Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            g.DrawString("Name: " + this.vendor.name, Font, Foreground, name);
            g.DrawString("Rating: "+this.vendor.rating.ToString()+" points", Font, Foreground, rating);
            g.DrawString("Today opened: " + Utilities.getTime(openVendor.start) + " - "+ Utilities.getTime(openVendor.end), Font, Foreground, open);

#else
            g.DrawString(ToolTipText, ToolTipFont, TooltipForeground, rect, ToolTipFormat);
#endif
        }

    }
}
