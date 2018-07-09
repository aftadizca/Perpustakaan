using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perputakaan
{
    public partial class bookSelect : Form
    {
        private readonly home _home;
        public string idUser { get; set; }
        public string idTransaksi { get; set; }

        public void loadDaftarBuku()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var listBuku = db.bukus.ToList();
                var listBukuPinjam = db.pinjams.Where(i => i.user_id == idUser && i.transaksi_id == idTransaksi).ToList();

                dataGridViewBuku.Rows.Clear();
                
                for (int i = 0; i < listBuku.Count; i++)
                {
                    var chk = false;

                    for (int j = 0; j < listBukuPinjam.Count; j++)
                    {
                        if (listBuku[i].id == listBukuPinjam[j].buku_id)
                        {
                            chk = true;
                        }
                    }
                    if (chk)
                    {
                        dataGridViewBuku.Rows.Add(true, listBuku[i].id, listBuku[i].judul, listBuku[i].penerbit, listBuku[i].pengarang);
                    }
                    else
                    {
                        dataGridViewBuku.Rows.Add(false, listBuku[i].id, listBuku[i].judul, listBuku[i].penerbit, listBuku[i].pengarang);
                    }
                }

            }
        }

        public void loadDaftarBukuFilter(string filter)
        {
            if (filter != "")
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var listBuku = db.bukus.Where(i => i.judul.Contains(filter)).ToList();
                    var listBukuPinjam = db.pinjams.Where(i => i.user_id == idUser && i.transaksi_id == idTransaksi).ToList();

                    dataGridViewBuku.Rows.Clear();

                    for (int i = 0; i < listBuku.Count; i++)
                    {
                        var chk = false;

                        for (int j = 0; j < listBukuPinjam.Count; j++)
                        {
                            if (listBuku[i].id == listBukuPinjam[j].buku_id)
                            {
                                chk = true;
                            }
                        }
                        if (chk)
                        {
                            dataGridViewBuku.Rows.Add(true, listBuku[i].id, listBuku[i].judul, listBuku[i].penerbit, listBuku[i].pengarang);
                        }
                        else
                        {
                            dataGridViewBuku.Rows.Add(false, listBuku[i].id, listBuku[i].judul, listBuku[i].penerbit, listBuku[i].pengarang);
                        }
                    }
                }      
            }
            else
            {
                loadDaftarBuku();
            }
        }


        public bookSelect(home f,string idPeminjam, string idtransaksi)
        {
            this._home = f;
            InitializeComponent();
            this.idUser = idPeminjam;
            this.idTransaksi = idtransaksi;
            loadDaftarBukuFilter("");
        }

        public bookSelect(string idPeminjam, string idtransaksi)
        {
            InitializeComponent();
            this.idUser = idPeminjam;
            this.idTransaksi = idtransaksi;
            loadDaftarBukuFilter("");
        }

        private void bookSelect_Load(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            loadDaftarBukuFilter(search.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _home.loadGridPinjam();
            this.Dispose();
        }

        private void dataGridViewBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex > -1 && grid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {

                var cb = grid.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                var idbuku = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                if ((bool)cb.Value)
                {
                    //Unchecked
                    //MessageBox.Show("UnChecked :" + grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cb.Value = false;
                    using (perpustakaanEntities db = new perpustakaanEntities())
                    {
                        var result = db.pinjams.FirstOrDefault(i => i.buku_id == idbuku && i.transaksi_id == idTransaksi && i.user_id == idUser);
                        if (result != null)
                        {
                            db.pinjams.Remove(result);
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    //Checked
                    //MessageBox.Show("Checked :" + grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cb.Value = true;
                    using (perpustakaanEntities db = new perpustakaanEntities())
                    {
                        pinjam _pinjam = new pinjam()
                        {
                            transaksi_id = idTransaksi,
                            user_id = idUser,
                            buku_id = idbuku
                        };

                        db.pinjams.Add(_pinjam);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
