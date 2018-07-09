namespace Perputakaan
{
    partial class AddBuku
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
            this.CariBuku = new System.Windows.Forms.GroupBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.DaftarBuku = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            this.idbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarangbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariBuku.SuspendLayout();
            this.DaftarBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // CariBuku
            // 
            this.CariBuku.BackColor = System.Drawing.Color.Transparent;
            this.CariBuku.Controls.Add(this.filter);
            this.CariBuku.Controls.Add(this.search);
            this.CariBuku.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariBuku.Location = new System.Drawing.Point(12, 12);
            this.CariBuku.Name = "CariBuku";
            this.CariBuku.Size = new System.Drawing.Size(379, 103);
            this.CariBuku.TabIndex = 7;
            this.CariBuku.TabStop = false;
            this.CariBuku.Text = "CARI BUKU";
            // 
            // filter
            // 
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "JUDUL",
            "PENGARANG",
            "PENERBIT"});
            this.filter.Location = new System.Drawing.Point(7, 59);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(366, 26);
            this.filter.TabIndex = 1;
            // 
            // search
            // 
            this.search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search.Location = new System.Drawing.Point(7, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(366, 26);
            this.search.TabIndex = 0;
            // 
            // DaftarBuku
            // 
            this.DaftarBuku.BackColor = System.Drawing.Color.Transparent;
            this.DaftarBuku.Controls.Add(this.dataGridViewBuku);
            this.DaftarBuku.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaftarBuku.Location = new System.Drawing.Point(12, 121);
            this.DaftarBuku.Name = "DaftarBuku";
            this.DaftarBuku.Size = new System.Drawing.Size(379, 222);
            this.DaftarBuku.TabIndex = 8;
            this.DaftarBuku.TabStop = false;
            this.DaftarBuku.Text = "DAFTAR BUKU";
            // 
            // dataGridViewBuku
            // 
            this.dataGridViewBuku.AllowUserToAddRows = false;
            this.dataGridViewBuku.AllowUserToDeleteRows = false;
            this.dataGridViewBuku.AllowUserToResizeRows = false;
            this.dataGridViewBuku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbuku,
            this.judulbuku,
            this.penerbitbuku,
            this.pengarangbuku});
            this.dataGridViewBuku.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewBuku.MultiSelect = false;
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.RowHeadersVisible = false;
            this.dataGridViewBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuku.Size = new System.Drawing.Size(363, 191);
            this.dataGridViewBuku.TabIndex = 0;
            // 
            // idbuku
            // 
            this.idbuku.HeaderText = "ID";
            this.idbuku.Name = "idbuku";
            this.idbuku.ReadOnly = true;
            this.idbuku.Width = 48;
            // 
            // judulbuku
            // 
            this.judulbuku.HeaderText = "JUDUL";
            this.judulbuku.Name = "judulbuku";
            this.judulbuku.ReadOnly = true;
            this.judulbuku.Width = 78;
            // 
            // penerbitbuku
            // 
            this.penerbitbuku.HeaderText = "PENERBIT";
            this.penerbitbuku.Name = "penerbitbuku";
            this.penerbitbuku.ReadOnly = true;
            this.penerbitbuku.Width = 96;
            // 
            // pengarangbuku
            // 
            this.pengarangbuku.HeaderText = "PENGARANG";
            this.pengarangbuku.Name = "pengarangbuku";
            this.pengarangbuku.Width = 128;
            // 
            // AddBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 355);
            this.Controls.Add(this.DaftarBuku);
            this.Controls.Add(this.CariBuku);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBuku";
            this.Text = "TAMBAH BUKU";
            this.CariBuku.ResumeLayout(false);
            this.CariBuku.PerformLayout();
            this.DaftarBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CariBuku;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.GroupBox DaftarBuku;
        private System.Windows.Forms.DataGridView dataGridViewBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangbuku;
    }
}