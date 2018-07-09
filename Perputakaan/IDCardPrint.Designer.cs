namespace Perputakaan
{
    partial class IDCardPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDCardPrint));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelTelp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBarcode = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(536, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "PRINT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Perputakaan.Properties.Resources.vector_flower_seamless_pattern_background_elegant_texture_for_backgrounds_classical_luxury_old_fashioned_floral_ornament_seamless_texture_for_wallpapers_textile_wrapping_1217_615;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.labelTelp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 387);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelAlamat
            // 
            this.labelAlamat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAlamat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.ForeColor = System.Drawing.Color.Teal;
            this.labelAlamat.Location = new System.Drawing.Point(199, 176);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(333, 124);
            this.labelAlamat.TabIndex = 7;
            this.labelAlamat.Text = "ALAMAT";
            // 
            // labelTelp
            // 
            this.labelTelp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelp.ForeColor = System.Drawing.Color.Teal;
            this.labelTelp.Location = new System.Drawing.Point(199, 302);
            this.labelTelp.Name = "labelTelp";
            this.labelTelp.Size = new System.Drawing.Size(333, 23);
            this.labelTelp.TabIndex = 6;
            this.labelTelp.Text = "TELP";
            this.labelTelp.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "NO. HP/TELP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(79, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ALAMAT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelNama
            // 
            this.labelNama.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNama.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.Teal;
            this.labelNama.Location = new System.Drawing.Point(199, 151);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(333, 23);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "NAMA";
            this.labelNama.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panelBarcode);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 129);
            this.panel3.TabIndex = 0;
            // 
            // panelBarcode
            // 
            this.panelBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarcode.Location = new System.Drawing.Point(285, 16);
            this.panelBarcode.Name = "panelBarcode";
            this.panelBarcode.Size = new System.Drawing.Size(313, 89);
            this.panelBarcode.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Perputakaan.Properties.Resources.LibraryLogo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(7, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 89);
            this.panel2.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // IDCartPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(615, 443);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IDCartPrint";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "KARTU ANGGOTA";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTelp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Panel panelBarcode;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}