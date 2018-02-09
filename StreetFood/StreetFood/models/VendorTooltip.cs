﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StreetFood.models
{
    class VendorTooltip : GMapBaloonToolTip
    {
        public VendorTooltip(GMapMarker marker)
         : base(marker)
        {
            Stroke = DefaultStroke;
            Fill = Brushes.Yellow;
    }

        public override void OnRender(Graphics g)
        {
            Size st = g.MeasureString(Marker.ToolTipText, Font).ToSize();
            Rectangle rect = new Rectangle(Marker.ToolTipPosition.X, Marker.ToolTipPosition.Y - st.Height, 250, 200);
            rect.Offset(Offset.X, Offset.Y);

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
                g.DrawPath(Stroke, objGP);
                
            }

#if !PocketPC
            g.DrawString(Marker.ToolTipText, Font, Foreground, rect);
#else
            g.DrawString(ToolTipText, ToolTipFont, TooltipForeground, rect, ToolTipFormat);
#endif
        }
    
    }
}
