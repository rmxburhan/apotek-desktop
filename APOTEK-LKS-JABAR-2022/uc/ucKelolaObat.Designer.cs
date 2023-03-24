namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucKelolaObat
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKodeObat = new System.Windows.Forms.TextBox();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpExp = new System.Windows.Forms.DateTimePicker();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgObat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgObat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode obat";
            // 
            // txtKodeObat
            // 
            this.txtKodeObat.Location = new System.Drawing.Point(8, 62);
            this.txtKodeObat.Name = "txtKodeObat";
            this.txtKodeObat.Size = new System.Drawing.Size(217, 22);
            this.txtKodeObat.TabIndex = 2;
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Location = new System.Drawing.Point(8, 107);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(217, 22);
            this.txtNamaObat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expired date";
            // 
            // dpExp
            // 
            this.dpExp.Location = new System.Drawing.Point(8, 152);
            this.dpExp.Name = "dpExp";
            this.dpExp.Size = new System.Drawing.Size(217, 22);
            this.dpExp.TabIndex = 6;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(303, 107);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(217, 22);
            this.txtHarga.TabIndex = 10;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validasi_AngkaTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(300, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Harga per unit";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(303, 62);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(217, 22);
            this.txtJumlah.TabIndex = 8;
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Validasi_AngkaTextBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(300, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jumlah stok";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(8, 180);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(83, 27);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(97, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 27);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(186, 180);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(83, 27);
            this.btnHapus.TabIndex = 13;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(346, 180);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(174, 22);
            this.txtFind.TabIndex = 15;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label7.Location = new System.Drawing.Point(300, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cari :";
            // 
            // dgObat
            // 
            this.dgObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObat.Location = new System.Drawing.Point(8, 213);
            this.dgObat.Name = "dgObat";
            this.dgObat.Size = new System.Drawing.Size(512, 220);
            this.dgObat.TabIndex = 16;
            this.dgObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgObat_CellClick);
            // 
            // ucKelolaObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgObat);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKodeObat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucKelolaObat";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucKelolaObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKodeObat;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpExp;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgObat;
    }
}
