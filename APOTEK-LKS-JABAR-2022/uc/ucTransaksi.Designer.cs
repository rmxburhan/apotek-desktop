namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucTransaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoResep = new System.Windows.Forms.TextBox();
            this.cbxTipeResep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpTglResep = new System.Windows.Forms.DateTimePicker();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dgKeranjang = new System.Windows.Forms.DataGridView();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.btnBayar = new System.Windows.Forms.Button();
            this.txtUang = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kelola transaksi";
            // 
            // txtNoResep
            // 
            this.txtNoResep.Location = new System.Drawing.Point(6, 94);
            this.txtNoResep.Name = "txtNoResep";
            this.txtNoResep.Size = new System.Drawing.Size(217, 22);
            this.txtNoResep.TabIndex = 39;
            // 
            // cbxTipeResep
            // 
            this.cbxTipeResep.FormattingEnabled = true;
            this.cbxTipeResep.Items.AddRange(new object[] {
            "TANPA RESEP",
            "DENGAN RESEP"});
            this.cbxTipeResep.Location = new System.Drawing.Point(6, 49);
            this.cbxTipeResep.Name = "cbxTipeResep";
            this.cbxTipeResep.Size = new System.Drawing.Size(217, 21);
            this.cbxTipeResep.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "No resep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tipe resep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tgl resep";
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Location = new System.Drawing.Point(6, 180);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(217, 22);
            this.txtNamaPasien.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nama pasien";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(314, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(217, 22);
            this.txtQuantity.TabIndex = 51;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(311, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Quantity";
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Location = new System.Drawing.Point(314, 94);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(217, 22);
            this.txtNamaObat.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(311, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Nama obat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label9.Location = new System.Drawing.Point(311, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nama dokter";
            // 
            // dpTglResep
            // 
            this.dpTglResep.Location = new System.Drawing.Point(6, 137);
            this.dpTglResep.Name = "dpTglResep";
            this.dpTglResep.Size = new System.Drawing.Size(217, 22);
            this.dpTglResep.TabIndex = 52;
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.Location = new System.Drawing.Point(314, 206);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(83, 27);
            this.btnKosongkan.TabIndex = 54;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = true;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(6, 206);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(83, 27);
            this.btnTambah.TabIndex = 53;
            this.btnTambah.Text = "Tambahkan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgKeranjang
            // 
            this.dgKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKeranjang.Location = new System.Drawing.Point(8, 239);
            this.dgKeranjang.Name = "dgKeranjang";
            this.dgKeranjang.Size = new System.Drawing.Size(523, 125);
            this.dgKeranjang.TabIndex = 56;
            // 
            // txtNamaDokter
            // 
            this.txtNamaDokter.Location = new System.Drawing.Point(314, 49);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(217, 22);
            this.txtNamaDokter.TabIndex = 57;
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(8, 406);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(83, 27);
            this.btnBayar.TabIndex = 58;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // txtUang
            // 
            this.txtUang.Location = new System.Drawing.Point(97, 410);
            this.txtUang.Name = "txtUang";
            this.txtUang.Size = new System.Drawing.Size(217, 22);
            this.txtUang.TabIndex = 59;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(394, 405);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 27);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.Text = "Print      Save";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrintSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label10.Location = new System.Drawing.Point(5, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label11.Location = new System.Drawing.Point(5, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 62;
            this.label11.Text = "Kembalian";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label12.Location = new System.Drawing.Point(94, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label13.Location = new System.Drawing.Point(94, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 63;
            this.label13.Text = ":";
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.lblKembalian.Location = new System.Drawing.Point(109, 386);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(0, 17);
            this.lblKembalian.TabIndex = 66;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.lblTotal.Location = new System.Drawing.Point(109, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 65;
            // 
            // ucTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtUang);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.txtNamaDokter);
            this.Controls.Add(this.dgKeranjang);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dpTglResep);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoResep);
            this.Controls.Add(this.cbxTipeResep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucTransaksi";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoResep;
        private System.Windows.Forms.ComboBox cbxTipeResep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpTglResep;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dgKeranjang;
        private System.Windows.Forms.TextBox txtNamaDokter;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.TextBox txtUang;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Label lblTotal;
    }
}
