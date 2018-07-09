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
    public partial class home : Form
    {

        #region **** KELOLA BUKU FUNCTION *****

        public string generateIdBuku()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = (from buku in db.bukus select buku).ToList().Count;
                if (result == 0)
                {
                    var id = String.Format("BK{0:00000000}", result + 1);
                    return id;
                }
                else
                {
                    var result2 = db.bukus.Max(i => i.id);
                    var id = String.Format("BK{0:00000000}", int.Parse(result2.Replace("BK", "")) + 1);
                    return id;
                }

            }
        }

        public void enableDetailBuku(bool _bool)
        {
            if (_bool == true)
            {
                judulTB.ReadOnly = false;
                penerbitTB.ReadOnly = false;
                pengarangTB.ReadOnly = false;
                tahunTerbit.Enabled = true;
                tanggalPengadaan.Enabled = true;
                rusakTB.ReadOnly = false;
                hilangTB.ReadOnly = false;
                jmlBukuTB.ReadOnly = false;
                lokasiTB.ReadOnly = false;
            }
            else
            {
                judulTB.ReadOnly = true;
                penerbitTB.ReadOnly = true;
                pengarangTB.ReadOnly = true;
                tahunTerbit.Enabled = false;
                tanggalPengadaan.Enabled = false;
                rusakTB.ReadOnly = true;
                hilangTB.ReadOnly = true;
                jmlBukuTB.ReadOnly = true;
                lokasiTB.ReadOnly = true;
            }

        }

        public bool cekDetailBuku()
        {
            if (judulTB.Text == "" ||
                    penerbitTB.Text == "" ||
                    pengarangTB.Text == "" ||
                    jmlBukuTB.Text == "" ||
                    lokasiTB.Text == "" ||
                    picture.ImageLocation == "")
            {
                MessageBox.Show("Data yang anda masukkan belum lengkap!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void clearInputDetailBuku()
        {
            picture.ImageLocation = "";
            idTB.Text = generateIdBuku();
            judulTB.Text = null;
            penerbitTB.Text = null;
            pengarangTB.Text = null;
            jmlBukuTB.Text = null;
            rusakTB.Text = "0";
            hilangTB.Text = "0";
            dipinjamTB.Text = "0";
            lokasiTB.Text = null;
        }

        public void loadInputDetailBuku(int index)
        {
            if (dataGridViewBuku.Rows.Count > 0)
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var id = dataGridViewBuku.Rows[index].Cells[0].Value.ToString();
                    var result = db.bukus.FirstOrDefault(i => i.id == id);
                    if (result != null)
                    {
                        picture.ImageLocation = result.gambar;
                        idTB.Text = result.id;
                        judulTB.Text = result.judul;
                        penerbitTB.Text = result.penerbit;
                        pengarangTB.Text = result.pengarang;
                        tahunTerbit.Value = result.tahun_terbit;
                        tanggalPengadaan.Value = result.tahun_pengadaan;
                        jmlBukuTB.Text = result.jumlah.ToString();
                        rusakTB.Text = result.rusak.ToString();
                        hilangTB.Text = result.hilang.ToString();
                        lokasiTB.Text = result.lokasi;
                        dipinjamTB.Text = result.dipinjam.ToString();
                    }

                }
            }
        }

        public void loadDaftarBuku()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var listBuku = db.bukus.ToList();
                dataGridViewBuku.Rows.Clear();
                Console.WriteLine(listBuku.Count);
                for (int i = 0; i < listBuku.Count; i++)
                {
                    Console.WriteLine(i);
                    dataGridViewBuku.Rows.Add(listBuku[i].id, listBuku[i].judul, listBuku[i].penerbit, listBuku[i].pengarang);
                }
            }
        }

        public void loadDaftarBukuFilter(string filter, string colomn)
        {
            if (filter != null || colomn != null)
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var listBuku = db.bukus.ToList();
                    switch (colomn)
                    {
                        case "JUDUL":
                            var temp = listBuku.Where(i => i.judul.Contains(filter)).ToList();
                            dataGridViewBuku.Rows.Clear();
                            for (int i = 0; i < temp.Count; i++)
                            {
                                dataGridViewBuku.Rows.Add(temp[i].id, temp[i].judul, temp[i].penerbit, temp[i].pengarang);
                            }
                            break;
                        case "PENGARANG":
                            var temp1 = listBuku.Where(i => i.pengarang.Contains(filter)).ToList();
                            dataGridViewBuku.Rows.Clear();
                            for (int i = 0; i < temp1.Count; i++)
                            {
                                dataGridViewBuku.Rows.Add(temp1[i].id, temp1[i].judul, temp1[i].penerbit, temp1[i].pengarang);
                            }
                            break;
                        case "PENERBIT":
                            var temp2 = listBuku.Where(i => i.penerbit.Contains(filter)).ToList();
                            dataGridViewBuku.Rows.Clear();
                            for (int i = 0; i < temp2.Count; i++)
                            {
                                dataGridViewBuku.Rows.Add(temp2[i].id, temp2[i].judul, temp2[i].penerbit, temp2[i].pengarang);
                            }
                            break;
                    }
                }
            }
            else
            {
                loadDaftarBuku();
            }
        }
        #endregion

        #region ****** KEANGGOTAAN ***********
        public string generateIdUser()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = (from buku in db.users select buku).ToList().Count;
                if (result == 0)
                {
                    var id = String.Format("ID{0:00000000}", result + 1);
                    return id;
                }
                else
                {
                    var result2 = db.users.Max(i => i.id);
                    var id = String.Format("ID{0:00000000}", int.Parse(result2.Replace("ID", "")) + 1);
                    return id;
                }
            }
        }

        public void loadDaftarAnggota()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var listAnggota = db.users.ToList();
                dataGridViewAnggota.Rows.Clear();
                Console.WriteLine(listAnggota.Count);
                for (int i = 0; i < listAnggota.Count; i++)
                {
                    Console.WriteLine(i);
                    dataGridViewBuku.Rows.Add(listAnggota[i].id, listAnggota[i].nama);
                }
            }
        }

        public void loadDaftarAnggotaFilter(string filter)
        {
            if (filter != null)
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var listAnggota = db.users.ToList();

                    var temp = listAnggota.Where(i => i.id.Contains(filter) || i.nama.Contains(filter)).ToList();

                    dataGridViewAnggota.Rows.Clear();

                    for (int i = 0; i < temp.Count; i++)
                    {
                        dataGridViewAnggota.Rows.Add(temp[i].id, temp[i].nama);
                    }
                }
            }
            else
            {
                loadDaftarAnggota();
            }
        }

        public bool cekDetailAnggota()
        {
            if (namaAnggotaTB.Text == "" ||
                    alamatAnggotaTB.Text == "" ||
                    telpAnggotaTB.Text == "")
            {
                MessageBox.Show("Data yang anda masukkan belum lengkap!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void loadInputDetailAnggota(int index)
        {
            if (dataGridViewAnggota.Rows.Count > 0)
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var id = dataGridViewAnggota.Rows[index].Cells[0].Value.ToString();
                    var result = db.users.FirstOrDefault(i => i.id == id);
                    if (result != null)
                    {
                        idAnggotaTB.Text = result.id;
                        namaAnggotaTB.Text = result.nama;
                        telpAnggotaTB.Text = result.telp;
                        ttlAnggotaTB.Value = (DateTime)result.tanggal_lahir;
                        alamatAnggotaTB.Text = result.alamat;
                    }

                }
            }
        }

        public void clearInputDetailAnggota()
        {
            idAnggotaTB.Text = generateIdUser();
            namaAnggotaTB.Text = null;
            telpAnggotaTB.Text = null;
            alamatAnggotaTB.Text = null;
        }

        public void enableDetailAnggota(bool _bool)
        {
            if (_bool == true)
            {
                idAnggotaTB.ReadOnly = false;
                namaAnggotaTB.ReadOnly = false;
                alamatAnggotaTB.ReadOnly = false;
                ttlAnggotaTB.Enabled = true;
                telpAnggotaTB.ReadOnly = false;
            }
            else
            {
                idAnggotaTB.ReadOnly = true;
                namaAnggotaTB.ReadOnly = true;
                alamatAnggotaTB.ReadOnly = true;
                ttlAnggotaTB.Enabled = false;
                telpAnggotaTB.ReadOnly = true;
            }

        }
        #endregion



        #region TRANSAKSI
        public string generateIdTransaksi()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = (from buku in db.transaksis select buku).ToList().Count;
                if (result == 0)
                {
                    var id = String.Format("TR{0:00000000}", result + 1);
                    return id;
                }
                else
                {
                    var result2 = db.transaksis.Max(i => i.id);
                    var id = String.Format("TR{0:00000000}", int.Parse(result2.Replace("TR", "")) + 1);
                    return id;
                }
            }
        }

        public void loadGridPinjam()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var bukuPinjam = from pinjam in db.pinjams
                                 from buku in db.bukus
                                 where pinjam.transaksi_id == idTR.Text && buku.id == pinjam.buku_id
                                 select new { Id = pinjam.buku_id, Judul = buku.judul };

                var bukuPinjamList = bukuPinjam.ToList();

                dataGridViewPinjam.Rows.Clear();
                for (int i = 0; i < bukuPinjamList.Count; i++)
                {
                    dataGridViewPinjam.Rows.Add(bukuPinjamList[i].Id, bukuPinjamList[i].Judul);
                }
            }
        }

        public void loadInputDetailTR(int index)
        {
            if (dataGridViewTR.Rows.Count > 0)
            {
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    var id = dataGridViewTR.Rows[index].Cells[0].Value.ToString();


                    if (dataGridViewTR.Rows[index].Cells[3].Value.ToString() == "DIKEMBALIKAN")
                    {
                        tanggalKembali.Visible = true;
                        buttonKembaliTR.Enabled = false;
                    }
                    else
                    {
                        tanggalKembali.Visible = false;
                        buttonKembaliTR.Enabled = true;
                    }


                    var result = from trans in db.transaksis
                                 from user in db.users
                                 from pinjam in db.pinjams
                                 where pinjam.transaksi_id == id && user.id == pinjam.user_id && trans.id == pinjam.transaksi_id
                                 select new { IdTrans = pinjam.transaksi_id, IdPeminjam = pinjam.user_id, NamaPeminjam = user.nama, TanggalPinjamStart = trans.tanggal_pinjam, TanggalPinjamEnd = trans.tanggal_kembali, TanggalKembali = trans.tanggal_kembali_real, Terlambat = trans.terlambat, Denda = trans.denda, Status = trans.status };

                    var list = result.Distinct().ToList();

                    if (list != null)
                    {
                        idTR.Text = list[0].IdTrans;
                        idAnggotaTR.Text = list[0].IdPeminjam;
                        namaTR.Text = list[0].NamaPeminjam;
                        tanggalPinjamStart.Value = (DateTime)list[0].TanggalPinjamStart;
                        tanggalPinjamEnd.Value = (DateTime)list[0].TanggalPinjamEnd;
                        tanggalKembali.Value = (DateTime)list[0].TanggalKembali;
                        terlambatTR.Text = list[0].Terlambat.ToString();
                        dendaTR.Text = list[0].Denda.ToString();


                        if (list[0].Status == "DIKEMBALIKAN")
                        {
                            tanggalKembali.Visible = true;
                        }
                        else
                        {
                            tanggalKembali.Visible = false;
                        }
                    }

                    loadGridPinjam();
                }
            }
        }

        public void loadDaftarTR()
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = from trans in db.transaksis
                             from user in db.users
                             from pinjam in db.pinjams
                             where trans.id == pinjam.transaksi_id && user.id == pinjam.user_id
                             select new { IdTrans = trans.id, IdPeminjam = user.id, NamaPeminjam = user.nama, TanggalPinjamStart = trans.tanggal_pinjam, TanggalPinjamEnd = trans.tanggal_kembali, TanggalKembali = trans.tanggal_kembali_real, Terlambat = trans.terlambat, Denda = trans.denda, Status = trans.status };

                var list = result.Distinct().ToList();
                dataGridViewTR.Rows.Clear();

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(i);
                    dataGridViewTR.Rows.Add(list[i].IdTrans, list[i].NamaPeminjam, list[i].TanggalPinjamStart, list[i].Status);
                }
            }
        }

        public void loadDaftarTRFilter(string search, string filter)
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                if (searchTR.Text != "")
                {
                    if (comboBoxFilterTR.Text == "SEMUA")
                    {

                        var result = from trans in db.transaksis
                                     from user in db.users
                                     from pinjam in db.pinjams
                                     where trans.id == pinjam.transaksi_id && user.id == pinjam.user_id && trans.id.Contains(searchTR.Text)
                                     select new { IdTrans = trans.id, IdPeminjam = user.id, NamaPeminjam = user.nama, TanggalPinjamStart = trans.tanggal_pinjam, TanggalPinjamEnd = trans.tanggal_kembali, TanggalKembali = trans.tanggal_kembali_real, Terlambat = trans.terlambat, Denda = trans.denda, Status = trans.status };

                        var list = result.Distinct().ToList();
                        dataGridViewTR.Rows.Clear();

                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(i);
                            dataGridViewTR.Rows.Add(list[i].IdTrans, list[i].NamaPeminjam, list[i].TanggalPinjamStart.Value.ToShortDateString(), list[i].Status);
                        }

                    }
                    else
                    {
                        var result = from trans in db.transaksis
                                     from user in db.users
                                     from pinjam in db.pinjams
                                     where trans.id == pinjam.transaksi_id && user.id == pinjam.user_id && trans.id.Contains(searchTR.Text) && trans.status == comboBoxFilterTR.Text
                                     select new { IdTrans = trans.id, IdPeminjam = user.id, NamaPeminjam = user.nama, TanggalPinjamStart = trans.tanggal_pinjam, TanggalPinjamEnd = trans.tanggal_kembali, TanggalKembali = trans.tanggal_kembali_real, Terlambat = trans.terlambat, Denda = trans.denda, Status = trans.status };

                        var list = result.Distinct().ToList();

                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(i);
                            dataGridViewTR.Rows.Add(list[i].IdTrans, list[i].NamaPeminjam, list[i].TanggalPinjamStart, list[i].Status);
                        }
                    }

                }
                else
                {
                    loadDaftarTR();
                }

            }

        }

        public bool cekDetailTR()
        {
            if (idAnggotaTR.Text == "" ||
                    dataGridViewPinjam.Rows.Count < 1)
            {
                MessageBox.Show("Data yang anda masukkan belum lengkap!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cancelPinjam(string idtransaksi)
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = db.pinjams.Where(i => i.transaksi_id == idtransaksi);
                if (result != null)
                {
                    db.pinjams.RemoveRange(result);
                    db.SaveChanges();
                }
            }
        }

        //public void loadAutoCompleteIdAnggota()
        //{
        //    using(perpustakaanEntities db = new perpustakaanEntities())
        //    {
        //        var result = db.users.ToList();
        //        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        //        for(int i = 0; i<result.Count; i++)
        //        {
        //            coll.Add(result[i].id);
        //        }
        //        idAnggotaTR.AutoCompleteCustomSource = coll;
        //    }
        //} 
        #endregion



        public home()
        {
            InitializeComponent();
            //Kelola Buku
            buttonSimpanKelola.Enabled = false;
            filter.SelectedIndex = 0;
            enableDetailBuku(false);
            loadDaftarBukuFilter("", "");
            loadInputDetailBuku(0);

            //Keanggotaan
            buttonSimpanUser.Enabled = false;
            enableDetailAnggota(false);
            loadDaftarAnggotaFilter("");
            loadInputDetailBuku(0);

            //Transaksi
            comboBoxFilterTR.SelectedIndex = 0;
            buttonSimpanTR.Enabled = false;
            loadDaftarTRFilter(searchTR.Text, comboBoxFilterTR.Text);
            loadInputDetailTR(0);
        }


        #region KELOLA BUKU EVENT
        private void buttonEditKelola_Click(object sender, EventArgs e)
        {
            if (buttonEditKelola.Text == "BATAL")
            {
                buttonTambahKelola.Enabled = true;
                buttonSimpanKelola.Enabled = false;
                buttonEditKelola.Text = "EDIT";

                loadInputDetailBuku(dataGridViewBuku.CurrentRow.Index);

                addPic.Visible = false;
                enableDetailBuku(false);
            }
            else if (buttonEditKelola.Text == "EDIT")
            {
                if (dataGridViewBuku.Rows.Count > 0)
                {
                    buttonTambahKelola.Enabled = false;
                    buttonSimpanKelola.Enabled = true;
                    buttonEditKelola.Text = "BATAL";

                    addPic.Visible = true;
                    enableDetailBuku(true);
                }
                else
                {
                    MessageBox.Show(this, "Daftar Buku Kosong." + Environment.NewLine + "Silahkan Tambah Buku", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
        }

        private void buttonTambahKelola_Click(object sender, EventArgs e)
        {
            if (buttonTambahKelola.Text == "TAMBAH")
            {
                clearInputDetailBuku();
                buttonEditKelola.Enabled = false;
                buttonSimpanKelola.Enabled = true;
                buttonTambahKelola.Text = "BATAL";
                CariBuku.Enabled = false;
                DaftarBuku.Enabled = false;
                enableDetailBuku(true);
                addPic.Visible = true;
                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    idTB.Text = generateIdBuku();
                }

            }
            else if (buttonTambahKelola.Text == "BATAL")
            {
                buttonEditKelola.Enabled = true;
                buttonSimpanKelola.Enabled = false;
                buttonTambahKelola.Text = "TAMBAH";
                CariBuku.Enabled = true;
                DaftarBuku.Enabled = true;
                enableDetailBuku(false);
                addPic.Visible = false;

                if (dataGridViewBuku.Rows.Count > 0)
                {
                    loadInputDetailBuku(dataGridViewBuku.CurrentRow.Index);
                }
            }
        }

        private void addPic_Click(object sender, EventArgs e)
        {
            openPicture.ShowDialog();
            picture.ImageLocation = openPicture.FileName;
        }

        private void buttonSimpanKelola_Click(object sender, EventArgs e)
        {
            if (buttonTambahKelola.Text == "BATAL")
            {
                if (cekDetailBuku())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {
                            idTB.Text = generateIdBuku();

                            buku _buku = new buku();
                            _buku.gambar = picture.ImageLocation;
                            _buku.id = idTB.Text;
                            _buku.judul = judulTB.Text;
                            _buku.penerbit = penerbitTB.Text;
                            _buku.pengarang = pengarangTB.Text;
                            _buku.tahun_pengadaan = tanggalPengadaan.Value;
                            _buku.tahun_terbit = tahunTerbit.Value;
                            _buku.jumlah = int.Parse(jmlBukuTB.Text);
                            _buku.rusak = int.Parse(rusakTB.Text);
                            _buku.hilang = int.Parse(hilangTB.Text);
                            _buku.dipinjam = int.Parse(dipinjamTB.Text);
                            _buku.lokasi = lokasiTB.Text;

                            db.bukus.Add(_buku);
                            db.SaveChanges();
                            var dialog = MessageBox.Show(this, "Buku Berhasil Ditambahkan." + Environment.NewLine + "Tambah buku lain?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.No)
                            {
                                buttonTambahKelola.PerformClick();
                                loadDaftarBukuFilter(search.Text, filter.Text);
                            }
                            else
                            {
                                clearInputDetailBuku();
                                loadDaftarBukuFilter(search.Text, filter.Text);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }

            if (buttonEditKelola.Text == "BATAL")
            {
                if (cekDetailBuku())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {
                            var _buku = db.bukus.First(i => i.id == idTB.Text);
                            _buku.gambar = picture.ImageLocation;
                            _buku.judul = judulTB.Text;
                            _buku.penerbit = penerbitTB.Text;
                            _buku.pengarang = pengarangTB.Text;
                            _buku.tahun_pengadaan = tanggalPengadaan.Value;
                            _buku.tahun_terbit = tahunTerbit.Value;
                            _buku.jumlah = int.Parse(jmlBukuTB.Text);
                            _buku.rusak = int.Parse(rusakTB.Text);
                            _buku.hilang = int.Parse(hilangTB.Text);
                            _buku.dipinjam = int.Parse(dipinjamTB.Text);
                            _buku.lokasi = lokasiTB.Text;
                            db.SaveChanges();
                            loadDaftarBukuFilter(search.Text, filter.Text);
                            var dialog = MessageBox.Show(this, "Buku Berhasil Disimpan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                buttonEditKelola.PerformClick();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text != null)
            {
                loadDaftarBukuFilter(search.Text, filter.Text);
            }
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filter.SelectedIndex != -1)
            {
                loadDaftarBukuFilter(search.Text, filter.Text);
            }
        }

        private void dataGridViewBuku_SelectionChanged(object sender, EventArgs e)
        {
            if (buttonTambahKelola.Text != "BATAL")
            {
                loadInputDetailBuku(dataGridViewBuku.CurrentRow.Index);
            }
        }

        //private void buttonHapusKelola_Click(object sender, EventArgs e)
        //{
        //    if (dataGridViewBuku.Rows.Count > 0)
        //    {
        //        var dialog = MessageBox.Show(this, "Hapus Buku ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dialog == DialogResult.Yes)
        //        {
        //            using (perpustakaanEntities db = new perpustakaanEntities())
        //            {
        //                var result = db.bukus.First(i => i.id == idTB.Text);
        //                db.bukus.Remove(result);
        //                db.SaveChanges();
        //                loadDaftarBukuFilter(search.Text, filter.Text);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(this, "Daftar Buku Kosong." + Environment.NewLine + "Silahkan Tambah Buku", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //    }
        //}

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region KEANGGOTAAN EVENT
        private void buttonTambahUser_Click(object sender, EventArgs e)
        {
            if (buttonTambahUser.Text == "TAMBAH")
            {
                clearInputDetailAnggota();

                buttonEditUser.Enabled = false;
                buttonPrintUser.Enabled = false;
                buttonSimpanUser.Enabled = true;

                buttonTambahUser.Text = "BATAL";

                cariAnggota.Enabled = false;
                daftarAnggota.Enabled = false;

                enableDetailAnggota(true);

                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    idAnggotaTB.Text = generateIdUser();
                }

            }
            else if (buttonTambahUser.Text == "BATAL")
            {
                buttonEditUser.Enabled = true;
                buttonPrintUser.Enabled = true;
                buttonSimpanUser.Enabled = false;

                buttonTambahUser.Text = "TAMBAH";

                cariAnggota.Enabled = true;
                daftarAnggota.Enabled = true;

                enableDetailAnggota(false);

                if (dataGridViewAnggota.Rows.Count > 0)
                {
                    loadInputDetailAnggota(dataGridViewAnggota.CurrentRow.Index);
                }
            }
        }

        private void buttonSimpanUser_Click(object sender, EventArgs e)
        {
            if (buttonTambahUser.Text == "BATAL")
            {
                if (cekDetailAnggota())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {
                            idAnggotaTB.Text = generateIdUser();

                            user _user = new user();
                            _user.id = idAnggotaTB.Text;
                            _user.nama = namaAnggotaTB.Text;
                            _user.telp = telpAnggotaTB.Text;
                            _user.alamat = alamatAnggotaTB.Text;
                            _user.tanggal_lahir = ttlAnggotaTB.Value;

                            db.users.Add(_user);
                            db.SaveChanges();

                            var dialog = MessageBox.Show(this, "Anggota Berhasil Ditambahkan." + Environment.NewLine + "Tambah Anggota Lain?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.No)
                            {
                                buttonTambahUser.PerformClick();
                                loadDaftarAnggotaFilter(searchAnggota.Text);
                            }
                            else
                            {
                                clearInputDetailAnggota();
                                loadDaftarAnggotaFilter(searchAnggota.Text);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }

            if (buttonEditUser.Text == "BATAL")
            {
                if (cekDetailAnggota())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {
                            var _user = db.users.First(i => i.id == idAnggotaTB.Text);

                            _user.nama = namaAnggotaTB.Text;
                            _user.alamat = alamatAnggotaTB.Text;
                            _user.telp = telpAnggotaTB.Text;
                            _user.tanggal_lahir = ttlAnggotaTB.Value;

                            db.SaveChanges();

                            loadDaftarAnggotaFilter(searchAnggota.Text);
                            var dialog = MessageBox.Show(this, "Data Anggota Berhasil Diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                buttonEditUser.PerformClick();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void searchAnggota_TextChanged(object sender, EventArgs e)
        {
            if (searchAnggota.Text != null)
            {
                loadDaftarAnggotaFilter(searchAnggota.Text);
            }
        }

        private void dataGridViewAnggota_SelectionChanged(object sender, EventArgs e)
        {
            if (buttonTambahUser.Text != "BATAL")
            {
                loadInputDetailAnggota(dataGridViewAnggota.CurrentRow.Index);
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            if (buttonEditUser.Text == "BATAL")
            {
                buttonTambahUser.Enabled = true;
                buttonSimpanUser.Enabled = false;
                buttonPrintUser.Enabled = true;

                buttonEditUser.Text = "EDIT";
                if (dataGridViewAnggota.Rows.Count > 0)
                {
                    loadInputDetailAnggota(dataGridViewAnggota.CurrentRow.Index);
                }

                enableDetailAnggota(false);
            }
            else if (buttonEditUser.Text == "EDIT")
            {
                if (dataGridViewAnggota.Rows.Count > 0)
                {
                    buttonTambahUser.Enabled = false;
                    buttonSimpanUser.Enabled = true;
                    buttonPrintUser.Enabled = false;

                    buttonEditUser.Text = "BATAL";
                    enableDetailAnggota(true);
                }
                else
                {
                    MessageBox.Show(this, "Anggota Kosong." + Environment.NewLine + "Silahkan Tambah Anggota", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
        }

        private void buttonPrintUser_Click(object sender, EventArgs e)
        {
            IDCardPrint dialog = new IDCardPrint(idAnggotaTB.Text, namaAnggotaTB.Text, alamatAnggotaTB.Text, telpAnggotaTB.Text);
            dialog.ShowDialog();
        }

        //private void buttonHapusUser_Click(object sender, EventArgs e)
        //{
        //    if (dataGridViewBuku.Rows.Count > 0)
        //    {
        //        var dialog = MessageBox.Show(this, "Hapus Anggota ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dialog == DialogResult.Yes)
        //        {
        //            using (perpustakaanEntities db = new perpustakaanEntities())
        //            {
        //                var result = db.bukus.First(i => i.id == idTB.Text);
        //                db.bukus.Remove(result);
        //                db.SaveChanges();
        //                loadDaftarBukuFilter(search.Text, filter.Text);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(this, "Daftar Buku Kosong." + Environment.NewLine + "Silahkan Tambah Buku", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //    }
        //} 
        #endregion


        private void buttonPinjamTR_Click(object sender, EventArgs e)
        {

            if (buttonPinjamTR.Text == "PINJAM")
            {

                buttonKembaliTR.Enabled = false;
                buttonPrintTR.Enabled = false;
                buttonSimpanTR.Enabled = true;

                buttonPinjamTR.Text = "BATAL";

                cariTR.Enabled = false;
                daftarTR.Enabled = false;
                dataGridViewPinjam.Rows.Clear();


                using (perpustakaanEntities db = new perpustakaanEntities())
                {
                    idTR.Text = generateIdTransaksi();
                }

                idAnggotaTR.ReadOnly = false;
                idAnggotaTR.Text = null;
                namaTR.Text = null;
                dendaTR.Text = "0";
                terlambatTR.Text = "0";
                tanggalPinjamEnd.Value = tanggalPinjamStart.Value.AddDays(7);
                tanggalKembali.Visible = false;


            }
            else if (buttonPinjamTR.Text == "BATAL")
            {

                cancelPinjam(idTR.Text);

                buttonKembaliTR.Enabled = true;
                buttonPrintTR.Enabled = true;
                buttonSimpanTR.Enabled = false;

                buttonPinjamTR.Text = "PINJAM";

                cariTR.Enabled = true;
                daftarTR.Enabled = true;

                idAnggotaTR.ReadOnly = true;

                if (dataGridViewTR.Rows.Count > 0)
                {
                    loadInputDetailTR(dataGridViewTR.CurrentRow.Index);
                }

            }
        }

        private void buttonAddBuku_Click(object sender, EventArgs e)
        {

        }

        private void idAnggotaTR_TextChanged(object sender, EventArgs e)
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var result = db.users.FirstOrDefault(i => i.id == idAnggotaTR.Text);
                if (result != null)
                {
                    namaTR.Text = result.nama;
                }
                else
                {
                    namaTR.Clear();
                }
            }
        }

        private void dataGridViewPinjam_DoubleClick(object sender, EventArgs e)
        {
            if (buttonPinjamTR.Text == "BATAL" && namaTR.Text != "")
            {
                bookSelect selectBook = new bookSelect(this, idAnggotaTR.Text, idTR.Text);
                selectBook.ShowDialog();
            }
        }

        private void buttonSimpanTR_Click(object sender, EventArgs e)
        {

            if (buttonPinjamTR.Text == "BATAL")
            {
                if (cekDetailTR())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {

                            transaksi tr = new transaksi()
                            {
                                id = idTR.Text,
                                tanggal_pinjam = DateTime.Now,
                                tanggal_kembali = DateTime.Now.AddDays(7),
                                tanggal_kembali_real = tanggalKembali.Value,
                                denda = long.Parse(dendaTR.Text),
                                terlambat = long.Parse(terlambatTR.Text),
                                status = "DIPINJAM"
                            };

                            db.transaksis.Add(tr);
                            db.SaveChanges();

                            var dialog = MessageBox.Show(this, "Transaksi Berhasil Dibuat." + Environment.NewLine + "Tambah Transaksi Lain?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.No)
                            {
                                buttonKembaliTR.Enabled = true;
                                buttonPrintTR.Enabled = true;
                                buttonSimpanTR.Enabled = false;

                                buttonPinjamTR.Text = "PINJAM";

                                cariTR.Enabled = true;
                                daftarTR.Enabled = true;

                                idAnggotaTR.ReadOnly = true;
                                loadDaftarTRFilter(searchTR.Text, comboBoxFilterTR.Text);
                            }
                            else
                            {
                                idAnggotaTR.Clear();
                                dataGridViewPinjam.Rows.Clear();
                                loadDaftarTRFilter(searchTR.Text, comboBoxFilterTR.Text);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }

            if (buttonKembaliTR.Text == "BATAL")
            {
                if (cekDetailTR())
                {
                    try
                    {
                        using (perpustakaanEntities db = new perpustakaanEntities())
                        {
                            //Perhitungan denda dan terlambat
                            var hari = DateTime.Now.Day - tanggalPinjamEnd.Value.Day;
                            var terlambat = (hari > 0) ? hari : 0;
                            var denda = terlambat * 2000;

                            var _user = db.transaksis.First(i => i.id == idTR.Text);

                            _user.tanggal_kembali_real = DateTime.Now;
                            _user.terlambat = terlambat;
                            _user.denda = denda;

                            db.SaveChanges();

                            loadDaftarTRFilter(searchTR.Text,comboBoxFilterTR.Text);
                            var dialog = MessageBox.Show(this, "Transaksi Pengembalian Berhasil Disimpan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dialog == DialogResult.OK)
                            {
                                buttonKembaliTR.PerformClick();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

        private void dataGridViewTR_SelectionChanged(object sender, EventArgs e)
        {
            loadInputDetailTR(dataGridViewTR.CurrentRow.Index);
        }

        private void searchTR_TextChanged(object sender, EventArgs e)
        {
            loadDaftarTRFilter(searchTR.Text, comboBoxFilterTR.Text);
        }

        private void comboBoxFilterTR_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDaftarTRFilter(searchTR.Text, comboBoxFilterTR.Text);
        }

        private void buttonKembaliTR_Click(object sender, EventArgs e)
        {
            if (buttonKembaliTR.Text == "KEMBALI")
            {

                buttonPinjamTR.Enabled = false;
                buttonPrintTR.Enabled = false;
                buttonSimpanTR.Enabled = true;

                buttonKembaliTR.Text = "BATAL";

                cariTR.Enabled = false;
                daftarTR.Enabled = false;

                tanggalKembali.Visible = true;


            }
            else if (buttonKembaliTR.Text == "BATAL")
            {


                buttonPinjamTR.Enabled = true;
                buttonPrintTR.Enabled = true;
                buttonSimpanTR.Enabled = false;

                buttonKembaliTR.Text = "KEMBALI";

                cariTR.Enabled = true;
                daftarTR.Enabled = true;

                tanggalKembali.Visible = false;

                if (dataGridViewTR.Rows.Count > 0)
                {
                    loadInputDetailTR(dataGridViewTR.CurrentRow.Index);
                }

            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPrintTR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
