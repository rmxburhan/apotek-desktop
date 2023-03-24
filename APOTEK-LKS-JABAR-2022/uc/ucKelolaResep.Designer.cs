namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucKelolaResep
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
            this.dgResep = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaDokter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dpTgl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoResep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResep)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResep
            // 
            this.dgResep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResep.Location = new System.Drawing.Point(8, 213);
            this.dgResep.Name = "dgResep";
            this.dgResep.Size = new System.Drawing.Size(512, 220);
            this.dgResep.TabIndex = 33;
            this.dgResep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResep_CellClick);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(346, 180);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(174, 22);
            this.txtFind.TabIndex = 32;
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
            this.label7.TabIndex = 31;
            this.label7.Text = "Cari :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(98, 180);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(83, 27);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 27);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Location = new System.Drawing.Point(303, 107);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(217, 22);
            this.txtNamaObat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(300, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nama obat";
            // 
            // txtNamaDokter
            // 
            this.txtNamaDokter.Location = new System.Drawing.Point(303, 62);
            this.txtNamaDokter.Name = "txtNamaDokter";
            this.txtNamaDokter.Size = new System.Drawing.Size(217, 22);
            this.txtNamaDokter.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(300, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nama dokter";
            // 
            // dpTgl
            // 
            this.dpTgl.Location = new System.Drawing.Point(9, 107);
            this.dpTgl.Name = "dpTgl";
            this.dpTgl.Size = new System.Drawing.Size(217, 22);
            this.dpTgl.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tgl resep";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Location = new System.Drawing.Point(9, 152);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(217, 22);
            this.txtNamaPasien.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama pasien";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNoResep
            // 
            this.txtNoResep.Location = new System.Drawing.Point(8, 62);
            this.txtNoResep.Name = "txtNoResep";
            this.txtNoResep.Size = new System.Drawing.Size(217, 22);
            this.txtNoResep.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "No resep";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kelola Resep";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(303, 152);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(217, 22);
            this.txtQty.TabIndex = 35;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(300, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Quantity";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ucKelolaResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgResep);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaDokter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpTgl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNoResep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucKelolaResep";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucKelolaResep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResep;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaDokter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpTgl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoResep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label8;
    }
}
