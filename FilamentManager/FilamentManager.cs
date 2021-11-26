using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager
{
    public partial class FilamentManager : Form
    {
        public FilamentManager()
        {
            InitializeComponent();
            FilamentMonitor monitor = new FilamentMonitor();
            monitor.Show();
        }

        private int rotation = 0;

        private void DrawFillamentSpool(PictureBox p, Graphics g, Color pFillamentColor, int rotation)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            SolidBrush brushFillament = new SolidBrush(pFillamentColor);

            int widthTenth = p.Width / 10;
            int heightTenth = p.Height / 10; 

            g.FillEllipse(Brushes.Black, new Rectangle(0, 0, p.Width, p.Height));

            Rectangle fillamentRect = new Rectangle(widthTenth, heightTenth, p.Width - 2 * widthTenth, p.Height - 2 * heightTenth);

            g.FillPie(brushFillament, fillamentRect, 0 + rotation, 90);
            g.FillPie(brushFillament, fillamentRect, 180 + rotation, 90);

            Rectangle innerRect = new Rectangle(widthTenth*4, heightTenth*4, p.Width - 8 * widthTenth, p.Height - 8 * heightTenth);
            g.FillEllipse(Brushes.White, innerRect);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            DrawFillamentSpool((PictureBox)sender, e.Graphics, Color.Red, rotation);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotation++;
            if (rotation >= 359) rotation = 0; 

            pictureBox1.Invalidate(); 
        }
    }
}
