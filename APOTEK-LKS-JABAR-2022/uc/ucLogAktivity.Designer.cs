namespace APOTEK_LKS_JABAR_2022.uc
{
    partial class ucLogAktivity
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
            this.dgLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dpExp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgLog
            // 
            this.dgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLog.Location = new System.Drawing.Point(8, 30);
            this.dgLog.Name = "dgLog";
            this.dgLog.Size = new System.Drawing.Size(512, 370);
            this.dgLog.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Log user";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(417, 406);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(103, 27);
            this.btnTambah.TabIndex = 49;
            this.btnTambah.Text = "Get Data";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dpExp
            // 
            this.dpExp.Location = new System.Drawing.Point(68, 407);
            this.dpExp.Name = "dpExp";
            this.dpExp.Size = new System.Drawing.Size(217, 22);
            this.dpExp.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(5, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tanggal";
            // 
            // ucLogAktivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dpExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgLog);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucLogAktivity";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucLogAktivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DateTimePicker dpExp;
        private System.Windows.Forms.Label label4;
    }
}
