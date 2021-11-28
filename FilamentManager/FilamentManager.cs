using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilamentManager
{
    public partial class FilamentManager : Form
    {
        Filament[] Filaments = new Filament[12];
        public FilamentManager()
        {
            //string[] args = Environment.GetCommandLineArgs();
            //int screen = Convert.ToInt32(args[1]);

            InitializeComponent();
            
            

            Filaments[0] = new Filament() { Color = Color.Red };
            Filaments[1] = new Filament() { Color = Color.Blue };
            Filaments[2] = new Filament() { Color = Color.Green };
            Filaments[3] = new Filament() { Color = Color.Yellow };
            Filaments[4] = new Filament() { Color = Color.Black };
            Filaments[5] = new Filament() { Color = Color.White };
            Filaments[6] = new Filament() { Color = Color.Aquamarine };
            Filaments[7] = new Filament() { Color = Color.DarkGreen };
            Filaments[8] = new Filament() { Color = Color.Chocolate };
            Filaments[9] = new Filament() { Color = Color.Crimson };
            Filaments[10] = new Filament() { Color = Color.Linen };
            Filaments[11] = new Filament() { Color = Color.Cornsilk };

            pbxSpoolA1.Tag = Filaments[0];
            pbxSpoolA2.Tag = Filaments[1];
            pbxSpoolA3.Tag = Filaments[2];
            pbxSpoolA4.Tag = Filaments[3];
            pbxSpoolB1.Tag = Filaments[4];
            pbxSpoolB2.Tag = Filaments[5];
            pbxSpoolB3.Tag = Filaments[6];
            pbxSpoolB4.Tag = Filaments[7];
            pbxSpoolC1.Tag = Filaments[8];
            pbxSpoolC2.Tag = Filaments[9];
            pbxSpoolC3.Tag = Filaments[10];
            pbxSpoolC4.Tag = Filaments[11];


            // Launch form on secondary monitor
            FilamentMonitor monitor = new FilamentMonitor();
            monitor.SelectedFilament = Filaments[6];
            monitor.StartPosition = FormStartPosition.Manual;
            monitor.Location = Screen.AllScreens[0].WorkingArea.Location;
            monitor.Show();
        }


        private void tmrSpoolRotate_Tick(object sender, EventArgs e)
        {
            foreach (Filament f in Filaments)
                f.DrawSpoolTick();

            foreach(GroupBox gb in Controls.OfType<GroupBox>())
            {
                foreach (PictureBox pb in gb.Controls.OfType<PictureBox>())
                {
                    Debug.Print(pb.Name);
                    pb.Invalidate();
                }
            }
            
        }

        private void PaintEventFilamentSpool(object sender, PaintEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Filament flm = (Filament)pb.Tag;
            flm.DrawSpool(pb, e.Graphics);         
        }

    }
}
