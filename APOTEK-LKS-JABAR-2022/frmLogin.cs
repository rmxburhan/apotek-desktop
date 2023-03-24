using APOTEK_LKS_JABAR_2022.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.       Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022
{
    public partial class frmLogin : Form
    {
        User user = new User();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) ||String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            var status = user.login(user);
            if (status == true)
            {
                this.Hide();
                txtUsername.Clear();
                txtPassword.Clear();
                new frmUtama(LoginSession.tipe).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username atau password anda salah");
            }
        }

    }
}