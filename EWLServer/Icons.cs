using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWLServer
{
    public static class Icons
    {
        public static readonly Bitmap reinit = new Bitmap(24, 24);
        public static readonly Bitmap upload = new Bitmap(24, 24);

        public static void InitIcons()
        {
            using (Graphics g = Graphics.FromImage(reinit))
            {
                GraphicsPath p = new GraphicsPath();
                p.AddLine(6, 4, 16, 4);
                p.AddLine(16, 4, 16, 13);
                p.AddLine(17, 14, 17, 19);
                p.AddLine(17, 19, 6, 19);
                p.AddLine(6, 19, 6, 4);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(Pens.Black, p);
                p.Reset();
                p.AddLine(16, 13, 15, 14);
                p.AddLine(15, 14, 15, 19);
                g.DrawPath(Pens.Black, p);
                p.Reset();
                p.AddLine(9, 11, 9, 9);
                p.AddLine(9, 9, 11, 9);
                g.DrawPath(Pens.Black, p);
                p.Reset();
                p.AddLine(13, 9, 13, 13);
                p.AddLine(13, 13, 9, 13);
                g.DrawPath(Pens.Black, p);
                p.Dispose();
            }
            using (Graphics g = Graphics.FromImage(upload))
            {
                GraphicsPath p = new GraphicsPath();
                p.AddLine(4, 6, 19, 6);
                p.AddLine(19, 6, 19, 17);
                p.AddLine(19, 17, 4, 17);
                p.AddLine(4, 17, 4, 6);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(Pens.Black, p);
                p.Reset();
                p.AddLine(6, 8, 12, 8);
                p.AddLine(12, 8, 12, 13);
                p.AddLine(12, 13, 6, 13);
                p.AddLine(6, 13, 6, 8);
                g.SmoothingMode = SmoothingMode.None;
                g.FillPath(Brushes.Black, p);
                p.Reset();
                p.AddLine(15, 13, 16, 13);
                p.AddLine(16, 13, 19, 15);
                p.AddLine(19, 15, 16, 15);
                p.AddLine(16, 15, 16, 18);
                p.AddLine(16, 18, 15, 18);
                p.AddLine(15, 18, 15, 15);
                p.AddLine(15, 15, 12, 15);
                p.AddLine(12, 15, 16, 13);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(Brushes.Black, p);
                g.DrawPath(Pens.Black, p);
                p.Dispose();
            }
        }
    }
}
