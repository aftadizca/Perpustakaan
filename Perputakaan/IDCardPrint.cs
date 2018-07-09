using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Printing;
using System.Diagnostics;

namespace Perputakaan
{
    public partial class IDCardPrint : Form
    {

        public string id { get; set; }
        public string nama { get; set; }
        public string alamat { get; set; }
        public string telp { get; set; }
        Bitmap bmp;

        public IDCardPrint(string id, string nama, string alamat, string telp)
        {
            InitializeComponent();
            this.id = id;
            this.nama = nama;
            this.alamat = alamat;
            this.telp = telp;

            labelNama.Text = nama;
            labelAlamat.Text = alamat;
            labelTelp.Text = telp;
            panelBarcode.BackgroundImage = createBarcode(this.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp,new Rectangle(0,0,panel1.Width,panel1.Height));
            bmp.Save("d:\\icon\\myid.png", ImageFormat.Png);

            Process.Start(@"d:\icon\myid.png");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        public static Bitmap createBarcode(string x)
        {
            Bitmap bitmap = new Bitmap(x.Length * 85, 280);
            using (Graphics grap = Graphics.FromImage(bitmap))
            {
                Font font = new Font("IDAHC39M Code 39 Barcode", 50);
                PointF point = new PointF(2f, 2f);
                SolidBrush bg = new SolidBrush(System.Drawing.Color.Transparent);
                SolidBrush fore = new SolidBrush(Color.Black);
                grap.FillRectangle(bg, 0, 0, bitmap.Width, bitmap.Height);
                grap.DrawString("*" + x + "*", font, fore, point);

            }

            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
            }

            return bitmap;

        }
    }
}
