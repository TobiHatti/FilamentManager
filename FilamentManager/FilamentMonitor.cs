using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FilamentManager
{
    public partial class FilamentMonitor : Form
    {
        public Filament SelectedFilament;

        public FilamentMonitor()
        {
            InitializeComponent();
        }

        private void tmrSpoolTick_Tick(object sender, EventArgs e)
        {
            SelectedFilament.DrawSpoolTick();
            pbxSpool.Invalidate();
        }

        private void pbxSpool_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SelectedFilament.DrawSpool(pb, e.Graphics);
        }
    }
}
