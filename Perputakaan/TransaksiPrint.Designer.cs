namespace Perputakaan
{
    partial class TransaksiPrint
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPinjam = new System.Windows.Forms.DataGridView();
            this.labelNama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBarcode = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pinjamTB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kembaliTB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUDULDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPinjam)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Perputakaan.Properties.Resources.vector_flower_seamless_pattern_background_elegant_texture_for_backgrounds_classical_luxury_old_fashioned_floral_ornament_seamless_texture_for_wallpapers_textile_wrapping_1217_615;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kembaliTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pinjamTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridViewPinjam);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 498);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewPinjam
            // 
            this.dataGridViewPinjam.AllowUserToAddRows = false;
            this.dataGridViewPinjam.AllowUserToDeleteRows = false;
            this.dataGridViewPinjam.AllowUserToResizeRows = false;
            this.dataGridViewPinjam.AutoGenerateColumns = false;
            this.dataGridViewPinjam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPinjam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.jUDULDataGridViewTextBoxColumn});
            this.dataGridViewPinjam.DataSource = this.myItemBindingSource;
            this.dataGridViewPinjam.Location = new System.Drawing.Point(79, 242);
            this.dataGridViewPinjam.MultiSelect = false;
            this.dataGridViewPinjam.Name = "dataGridViewPinjam";
            this.dataGridViewPinjam.ReadOnly = true;
            this.dataGridViewPinjam.RowHeadersVisible = false;
            this.dataGridViewPinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPinjam.Size = new System.Drawing.Size(453, 241);
            this.dataGridViewPinjam.TabIndex = 36;
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
            this.label1.Text = "ID TRANSAKSI";
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
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(461, 506);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 33);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "PRINT";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(542, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pinjamTB
            // 
            this.pinjamTB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pinjamTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinjamTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinjamTB.ForeColor = System.Drawing.Color.Teal;
            this.pinjamTB.Location = new System.Drawing.Point(199, 178);
            this.pinjamTB.Name = "pinjamTB";
            this.pinjamTB.Size = new System.Drawing.Size(333, 23);
            this.pinjamTB.TabIndex = 38;
            this.pinjamTB.Text = "NAMA";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(79, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "PINJAM";
            // 
            // kembaliTB
            // 
            this.kembaliTB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.kembaliTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kembaliTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliTB.ForeColor = System.Drawing.Color.Teal;
            this.kembaliTB.Location = new System.Drawing.Point(199, 205);
            this.kembaliTB.Name = "kembaliTB";
            this.kembaliTB.Size = new System.Drawing.Size(333, 23);
            this.kembaliTB.TabIndex = 40;
            this.kembaliTB.Text = "NAMA";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "KEMBALI";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 35F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jUDULDataGridViewTextBoxColumn
            // 
            this.jUDULDataGridViewTextBoxColumn.DataPropertyName = "JUDUL";
            this.jUDULDataGridViewTextBoxColumn.HeaderText = "JUDUL";
            this.jUDULDataGridViewTextBoxColumn.Name = "jUDULDataGridViewTextBoxColumn";
            this.jUDULDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // myItemBindingSource
            // 
            this.myItemBindingSource.DataSource = typeof(Perputakaan.MyItem);
            // 
            // TransaksiPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 545);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransaksiPrint";
            this.Text = "Print Transaksi";
            this.Load += new System.EventHandler(this.TransaksiPrint_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPinjam)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelBarcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewPinjam;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kembaliTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pinjamTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUDULDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource myItemBindingSource;
    }
}