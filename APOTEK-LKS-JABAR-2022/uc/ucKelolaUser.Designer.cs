namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucKelolaUser
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
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipeUser = new System.Windows.Forms.ComboBox();
            this.txtNamaUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUser
            // 
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(8, 213);
            this.dgUser.Name = "dgUser";
            this.dgUser.Size = new System.Drawing.Size(512, 220);
            this.dgUser.TabIndex = 33;
            this.dgUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellClick);
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
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(186, 180);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(83, 27);
            this.btnHapus.TabIndex = 30;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(97, 180);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 27);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(8, 180);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(83, 27);
            this.btnTambah.TabIndex = 28;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(300, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(300, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipe user";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kelola User";
            // 
            // cbxTipeUser
            // 
            this.cbxTipeUser.FormattingEnabled = true;
            this.cbxTipeUser.Items.AddRange(new object[] {
            "admin",
            "apoteker",
            "kasir"});
            this.cbxTipeUser.Location = new System.Drawing.Point(8, 62);
            this.cbxTipeUser.Name = "cbxTipeUser";
            this.cbxTipeUser.Size = new System.Drawing.Size(217, 21);
            this.cbxTipeUser.TabIndex = 34;
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.Location = new System.Drawing.Point(8, 107);
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.Size = new System.Drawing.Size(217, 22);
            this.txtNamaUser.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label8.Location = new System.Drawing.Point(300, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Password";
            // 
            // txtTelepon
            // 
            this.txtTelepon.Location = new System.Drawing.Point(8, 152);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(217, 22);
            this.txtTelepon.TabIndex = 39;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(303, 62);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(217, 22);
            this.txtAlamat.TabIndex = 40;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(303, 107);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 22);
            this.txtUsername.TabIndex = 41;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(303, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 22);
            this.txtPassword.TabIndex = 42;
            // 
            // ucKelolaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNamaUser);
            this.Controls.Add(this.cbxTipeUser);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucKelolaUser";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucKelolaUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipeUser;
        private System.Windows.Forms.TextBox txtNamaUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
