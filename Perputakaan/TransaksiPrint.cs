using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perputakaan
{
    public partial class TransaksiPrint : Form
    {
        Bitmap bmp;
        String idTransaksi;
        String pinjamx;
        String kembalix;
        List<MyItem> dataTable;

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

        public TransaksiPrint(string idTransaksi,string pinjam,string kembali, List<MyItem> data)
        {
            this.idTransaksi = idTransaksi;
            this.dataTable = data;
            this.pinjamx = pinjam;
            this.kembalix = kembali;
            InitializeComponent();
            labelNama.Text = idTransaksi;
            dataGridViewPinjam.DataSource = dataTable;
            panelBarcode.BackgroundImage = createBarcode(this.idTransaksi);
            pinjamTB.Text = pinjamx;
            kembaliTB.Text = kembalix;
        }

        private void TransaksiPrint_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            bmp.Save("d:\\icon\\mytrans.png", ImageFormat.Png);

            Process.Start(@"d:\icon\mytrans.png");
        }
    }
}
