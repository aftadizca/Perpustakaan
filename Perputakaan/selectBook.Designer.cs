namespace Perputakaan
{
    partial class bookSelect
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
            this.DaftarBuku = new System.Windows.Forms.GroupBox();
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penerbitbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengarangbuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariBuku = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.DaftarBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.CariBuku.SuspendLayout();
            this.SuspendLayout();
            // 
            // DaftarBuku
            // 
            this.DaftarBuku.BackColor = System.Drawing.Color.Transparent;
            this.DaftarBuku.Controls.Add(this.dataGridViewBuku);
            this.DaftarBuku.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaftarBuku.Location = new System.Drawing.Point(27, 93);
            this.DaftarBuku.Name = "DaftarBuku";
            this.DaftarBuku.Size = new System.Drawing.Size(379, 352);
            this.DaftarBuku.TabIndex = 9;
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
            this.cb,
            this.idbuku,
            this.judulbuku,
            this.penerbitbuku,
            this.pengarangbuku});
            this.dataGridViewBuku.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewBuku.MultiSelect = false;
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.RowHeadersVisible = false;
            this.dataGridViewBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuku.Size = new System.Drawing.Size(363, 321);
            this.dataGridViewBuku.TabIndex = 0;
            this.dataGridViewBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuku_CellContentClick);
            // 
            // cb
            // 
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cb.Width = 19;
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
            this.pengarangbuku.ReadOnly = true;
            this.pengarangbuku.Width = 128;
            // 
            // CariBuku
            // 
            this.CariBuku.BackColor = System.Drawing.Color.Transparent;
            this.CariBuku.Controls.Add(this.search);
            this.CariBuku.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CariBuku.Location = new System.Drawing.Point(27, 16);
            this.CariBuku.Name = "CariBuku";
            this.CariBuku.Size = new System.Drawing.Size(379, 71);
            this.CariBuku.TabIndex = 8;
            this.CariBuku.TabStop = false;
            this.CariBuku.Text = "MASSUKKAN ID BUKU";
            // 
            // search
            // 
            this.search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.search.Location = new System.Drawing.Point(7, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(366, 26);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(325, 451);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 38);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // bookSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 501);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.DaftarBuku);
            this.Controls.Add(this.CariBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bookSelect";
            this.Text = "PILIH BUKU";
            this.Load += new System.EventHandler(this.bookSelect_Load);
            this.DaftarBuku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.CariBuku.ResumeLayout(false);
            this.CariBuku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DaftarBuku;
        private System.Windows.Forms.DataGridView dataGridViewBuku;
        private System.Windows.Forms.GroupBox CariBuku;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn penerbitbuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangbuku;
    }
}