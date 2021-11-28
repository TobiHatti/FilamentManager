namespace FilamentManager
{
    partial class FilamentManager
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxSpoolA1 = new System.Windows.Forms.PictureBox();
            this.tmrSpoolRotate = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolA2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolA3 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolA4 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolB4 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolB3 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolB2 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolB1 = new System.Windows.Forms.PictureBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolC4 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolC3 = new System.Windows.Forms.PictureBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolC2 = new System.Windows.Forms.PictureBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.pbxSpoolC1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA4)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB3)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB2)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB1)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC4)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC3)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC2)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSpoolA1
            // 
            this.pbxSpoolA1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolA1.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolA1.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolA1.Name = "pbxSpoolA1";
            this.pbxSpoolA1.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolA1.TabIndex = 0;
            this.pbxSpoolA1.TabStop = false;
            this.pbxSpoolA1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // tmrSpoolRotate
            // 
            this.tmrSpoolRotate.Enabled = true;
            this.tmrSpoolRotate.Interval = 10;
            this.tmrSpoolRotate.Tick += new System.EventHandler(this.tmrSpoolRotate_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxSpoolA1);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(305, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filament Slot A1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbxSpoolA2);
            this.groupBox2.Location = new System.Drawing.Point(329, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(305, 200);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filament Slot A2";
            // 
            // pbxSpoolA2
            // 
            this.pbxSpoolA2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolA2.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolA2.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolA2.Name = "pbxSpoolA2";
            this.pbxSpoolA2.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolA2.TabIndex = 1;
            this.pbxSpoolA2.TabStop = false;
            this.pbxSpoolA2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbxSpoolA3);
            this.groupBox3.Location = new System.Drawing.Point(642, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(305, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filament Slot A3";
            // 
            // pbxSpoolA3
            // 
            this.pbxSpoolA3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolA3.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolA3.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolA3.Name = "pbxSpoolA3";
            this.pbxSpoolA3.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolA3.TabIndex = 2;
            this.pbxSpoolA3.TabStop = false;
            this.pbxSpoolA3.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbxSpoolA4);
            this.groupBox4.Location = new System.Drawing.Point(955, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(305, 200);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filament Slot A4";
            // 
            // pbxSpoolA4
            // 
            this.pbxSpoolA4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolA4.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolA4.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolA4.Name = "pbxSpoolA4";
            this.pbxSpoolA4.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolA4.TabIndex = 3;
            this.pbxSpoolA4.TabStop = false;
            this.pbxSpoolA4.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pbxSpoolB4);
            this.groupBox5.Location = new System.Drawing.Point(955, 226);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(305, 200);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filament Slot B4";
            // 
            // pbxSpoolB4
            // 
            this.pbxSpoolB4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolB4.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolB4.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolB4.Name = "pbxSpoolB4";
            this.pbxSpoolB4.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolB4.TabIndex = 3;
            this.pbxSpoolB4.TabStop = false;
            this.pbxSpoolB4.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pbxSpoolB3);
            this.groupBox6.Location = new System.Drawing.Point(642, 226);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(305, 200);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filament Slot B3";
            // 
            // pbxSpoolB3
            // 
            this.pbxSpoolB3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolB3.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolB3.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolB3.Name = "pbxSpoolB3";
            this.pbxSpoolB3.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolB3.TabIndex = 2;
            this.pbxSpoolB3.TabStop = false;
            this.pbxSpoolB3.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pbxSpoolB2);
            this.groupBox7.Location = new System.Drawing.Point(329, 226);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(305, 200);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filament Slot B2";
            // 
            // pbxSpoolB2
            // 
            this.pbxSpoolB2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolB2.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolB2.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolB2.Name = "pbxSpoolB2";
            this.pbxSpoolB2.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolB2.TabIndex = 1;
            this.pbxSpoolB2.TabStop = false;
            this.pbxSpoolB2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pbxSpoolB1);
            this.groupBox8.Location = new System.Drawing.Point(16, 226);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(305, 200);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Filament Slot B1";
            // 
            // pbxSpoolB1
            // 
            this.pbxSpoolB1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolB1.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolB1.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolB1.Name = "pbxSpoolB1";
            this.pbxSpoolB1.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolB1.TabIndex = 0;
            this.pbxSpoolB1.TabStop = false;
            this.pbxSpoolB1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pbxSpoolC4);
            this.groupBox9.Location = new System.Drawing.Point(955, 434);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(305, 200);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filament Slot C4";
            // 
            // pbxSpoolC4
            // 
            this.pbxSpoolC4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolC4.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolC4.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolC4.Name = "pbxSpoolC4";
            this.pbxSpoolC4.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolC4.TabIndex = 3;
            this.pbxSpoolC4.TabStop = false;
            this.pbxSpoolC4.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pbxSpoolC3);
            this.groupBox10.Location = new System.Drawing.Point(642, 434);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(305, 200);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Filament Slot C3";
            // 
            // pbxSpoolC3
            // 
            this.pbxSpoolC3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolC3.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolC3.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolC3.Name = "pbxSpoolC3";
            this.pbxSpoolC3.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolC3.TabIndex = 2;
            this.pbxSpoolC3.TabStop = false;
            this.pbxSpoolC3.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.pbxSpoolC2);
            this.groupBox11.Location = new System.Drawing.Point(329, 434);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox11.Size = new System.Drawing.Size(305, 200);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filament Slot C2";
            // 
            // pbxSpoolC2
            // 
            this.pbxSpoolC2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolC2.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolC2.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolC2.Name = "pbxSpoolC2";
            this.pbxSpoolC2.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolC2.TabIndex = 1;
            this.pbxSpoolC2.TabStop = false;
            this.pbxSpoolC2.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.pbxSpoolC1);
            this.groupBox12.Location = new System.Drawing.Point(16, 434);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(305, 200);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Filament Slot C1";
            // 
            // pbxSpoolC1
            // 
            this.pbxSpoolC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpoolC1.Location = new System.Drawing.Point(8, 28);
            this.pbxSpoolC1.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSpoolC1.Name = "pbxSpoolC1";
            this.pbxSpoolC1.Size = new System.Drawing.Size(164, 164);
            this.pbxSpoolC1.TabIndex = 0;
            this.pbxSpoolC1.TabStop = false;
            this.pbxSpoolC1.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintEventFilamentSpool);
            // 
            // FilamentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "FilamentManager";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolA4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB2)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolB1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC4)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC3)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC2)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpoolC1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSpoolA1;
        private System.Windows.Forms.Timer tmrSpoolRotate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbxSpoolA2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbxSpoolA3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbxSpoolA4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pbxSpoolB4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pbxSpoolB3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pbxSpoolB2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pbxSpoolB1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pbxSpoolC4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox pbxSpoolC3;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox pbxSpoolC2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.PictureBox pbxSpoolC1;
    }
}

