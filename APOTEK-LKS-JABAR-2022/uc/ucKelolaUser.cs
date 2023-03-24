using APOTEK_LKS_JABAR_2022.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace APOTEK_LKS_JABAR_2022.uc
{
    public partial class ucKelolaUser : UserControl
    {
        User user = new User();
        public ucKelolaUser()
        {
            InitializeComponent();
        }

        private void ucKelolaUser_Load(object sender, EventArgs e)
        {
            clear();
            user.getData(null, dgUser);
        }

        private void clear()
        {
            cbxTipeUser.SelectedIndex = -1;
            txtNamaUser.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNamaUser.Text) || String.IsNullOrEmpty(txtTelepon.Text) || String.IsNullOrEmpty(txtAlamat.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || cbxTipeUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Lengkapi semua data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.tipe_user = cbxTipeUser.SelectedItem.ToString();
                user.nama = txtNamaUser.Text;
                user.password = txtPassword.Text;
                user.telepon = txtTelepon.Text;
                user.alamat = txtAlamat.Text;
                user.username = txtUsername.Text;
                int n = user.addData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil disimpan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    user.getData(null, dgUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtNamaUser.Text) || String.IsNullOrEmpty(txtTelepon.Text) || String.IsNullOrEmpty(txtAlamat.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || cbxTipeUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Lengkapi semua data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.tipe_user = cbxTipeUser.SelectedItem.ToString();
                user.nama = txtNamaUser.Text;
                user.password = txtPassword.Text;
                user.telepon = txtTelepon.Text;
                user.alamat = txtAlamat.Text;
                int n = user.editData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.id = 0;
                    clear();
                    user.getData(null, dgUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = user.deleteData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                { 
                    MessageBox.Show("Data berhasil dihapus", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.id = 0;
                    clear();
                    user.getData(null, dgUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            user.getData(txtFind.Text, dgUser);
        }

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                user.id = Convert.ToInt32(dgUser.Rows[row_index].Cells[0].Value.ToString());
                user.tipe_user = dgUser.Rows[row_index].Cells[1].Value.ToString();
                user.nama = dgUser.Rows[row_index].Cells[2].Value.ToString();
                user.password = dgUser.Rows[row_index].Cells[3].Value.ToString();
                user.username =dgUser.Rows[row_index].Cells[4].Value.ToString();
                user.telepon = dgUser.Rows[row_index].Cells[5].Value.ToString();
                user.alamat = dgUser.Rows[row_index].Cells[6].Value.ToString();
                int i = cbxTipeUser.Items.IndexOf(user.tipe_user);
                cbxTipeUser.SelectedIndex = i;
                txtNamaUser.Text = user.nama;
                txtAlamat.Text = user.alamat;
                txtTelepon.Text = user.telepon;
                txtUsername.Text = user.username;
                txtPassword.Text = user.password;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
