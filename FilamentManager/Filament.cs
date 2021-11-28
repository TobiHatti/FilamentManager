using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager
{


    public class Filament
    {
        public Color Color { get; set; } = Color.Black;







        private int rotationCounter = 0;

        public void DrawSpoolTick()
        {
            rotationCounter++;
            if (rotationCounter >= 359) rotationCounter = 0;
        }

        public void DrawSpool(PictureBox p, Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Brush brushFillament = new SolidBrush(Color);
            Brush spoolColor = new SolidBrush(Color.FromArgb(50, 50, 50));

            int widthTenth = p.Width / 10;
            int heightTenth = p.Height / 10;

            g.FillEllipse(spoolColor, new Rectangle(0, 0, p.Width, p.Height));

            Rectangle fillamentRect = new Rectangle(widthTenth, heightTenth, p.Width - 2 * widthTenth, p.Height - 2 * heightTenth);
            Rectangle fillamentRectInner = new Rectangle((int)(widthTenth * 1.5), (int)(heightTenth * 1.5), p.Width - 3 * widthTenth, p.Height - 3 * heightTenth);
            Rectangle fillamentLineRect = new Rectangle(p.Width / 2, heightTenth * 1, p.Width / 2, heightTenth / 2);

            g.FillRectangle(brushFillament, fillamentLineRect);

            g.FillEllipse(brushFillament, fillamentRect);
            g.FillEllipse(spoolColor, fillamentRectInner);

            g.FillPie(brushFillament, fillamentRect, 0 + rotationCounter, 90);
            g.FillPie(brushFillament, fillamentRect, 180 + rotationCounter, 90);



            Rectangle innerRect = new Rectangle(widthTenth * 3, heightTenth * 3, p.Width - 6 * widthTenth, p.Height - 6 * heightTenth);
            g.FillEllipse(Brushes.White, innerRect);

            g.FillPie(spoolColor, innerRect, 0 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 45 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 90 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 135 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 180 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 225 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 270 + rotationCounter, 20);
            g.FillPie(spoolColor, innerRect, 315 + rotationCounter, 20);

            Rectangle innerRect2 = new Rectangle((int)(widthTenth * 3.5), (int)(heightTenth * 3.5), p.Width - 7 * widthTenth, p.Height - 7 * heightTenth);
            g.FillEllipse(spoolColor, innerRect2);

            Rectangle innerRect3 = new Rectangle(widthTenth * 4, heightTenth * 4, p.Width - 8 * widthTenth, p.Height - 8 * heightTenth);
            g.FillEllipse(Brushes.White, innerRect3);
        }
    }
}
