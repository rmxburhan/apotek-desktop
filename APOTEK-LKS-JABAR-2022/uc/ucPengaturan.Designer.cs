namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucPengaturan
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
            this.txtNamaAplikasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMap = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pengaturan Aplikasi";
            // 
            // txtNamaAplikasi
            // 
            this.txtNamaAplikasi.Location = new System.Drawing.Point(8, 70);
            this.txtNamaAplikasi.Name = "txtNamaAplikasi";
            this.txtNamaAplikasi.Size = new System.Drawing.Size(217, 22);
            this.txtNamaAplikasi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Toko / Aplikasi";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(8, 124);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(217, 22);
            this.txtLat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lat";
            // 
            // txtLng
            // 
            this.txtLng.Location = new System.Drawing.Point(243, 124);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(217, 22);
            this.txtLng.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(240, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lng";
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Brown;
            this.panelMap.Location = new System.Drawing.Point(8, 164);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(513, 218);
            this.panelMap.TabIndex = 10;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(8, 388);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 37);
            this.btnSimpan.TabIndex = 11;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(466, 124);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(55, 22);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ucPengaturan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.txtLng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaAplikasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucPengaturan";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucPengaturan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaAplikasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnGo;
    }
}
