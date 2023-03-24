using APOTEK_LKS_JABAR_2022.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022.uc
{
    public partial class ucKelolaResep : UserControl
    {
        Resep resep = new Resep();
        public ucKelolaResep()
        {
            InitializeComponent();
        }

        private void ucKelolaResep_Load(object sender, EventArgs e)
        {
            clear();
            resep.getData(null, dgResep);
        }

        private void clear()
        {
            txtNoResep.Clear();
            dpTgl.Value = DateTime.Now;
            txtNamaPasien.Clear();
            txtNamaDokter.Clear();
            txtNamaObat.Clear();
            txtQty.Clear();
            txtFind.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (resep.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtNoResep.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtNamaPasien.Text) || String.IsNullOrEmpty(txtNamaDokter.Text) || String.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Lengkapi semua data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                resep.no_resep = txtNoResep.Text;
                resep.tgl_resep = dpTgl.Value;
                resep.nama_pasien = txtNamaPasien.Text;
                resep.nama_dokter = txtNamaDokter.Text;
                resep.obat_resep = txtNamaObat.Text;
                resep.jumlah_obat = Convert.ToInt32(txtQty.Text);
                int n = resep.editData(resep);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resep.id = 0;
                    clear();
                    resep.getData(null, dgResep);
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
                if (resep.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = resep.deleteData(resep);
                if (n == 0)
                    MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil dihapus", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resep.id = 0;
                    clear();
                    resep.getData(null, dgResep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            resep.getData(txtFind.Text, dgResep);
        }

        private void dgResep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                resep.id = Convert.ToInt32(dgResep.Rows[index].Cells[0].Value.ToString());
                resep.no_resep = dgResep.Rows[index].Cells[1].Value.ToString();
                resep.tgl_resep = Convert.ToDateTime(dgResep.Rows[index].Cells[2].Value.ToString());
                resep.nama_pasien = dgResep.Rows[index].Cells[3].Value.ToString();
                resep.nama_dokter = dgResep.Rows[index].Cells[4].Value.ToString();
                resep.obat_resep = dgResep.Rows[index].Cells[5].Value.ToString();
                resep.jumlah_obat = Convert.ToInt32(dgResep.Rows[index].Cells[6].Value.ToString());
                txtNoResep.Text = resep.no_resep;
                dpTgl.Value = resep.tgl_resep;
                txtNamaPasien.Text = resep.nama_pasien;
                txtNamaDokter.Text = resep.nama_dokter;
                txtNamaObat.Text = resep.obat_resep;
                txtQty.Text = resep.jumlah_obat.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
