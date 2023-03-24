using APOTEK_LKS_JABAR_2022.models;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022.uc
{
    public partial class ucKelolaObat : UserControl
    {
        Obat obat = new Obat();
        public ucKelolaObat()
        {
            InitializeComponent();
        }
        private void ucKelolaObat_Load(object sender, EventArgs e)
        {
            clear();
            obat.getData(null, dgObat);
        }

        private void clear()
        {
            txtNamaObat.Clear();
            txtKodeObat.Clear();
            dpExp.Value = DateTime.Now;
            txtJumlah.Clear();
            txtHarga.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJumlah.Text) || String.IsNullOrEmpty(txtHarga.Text))
                {
                    MessageBox.Show("Lengkapi semua data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                obat.nama_obat = txtNamaObat.Text;
                obat.kode_obat = txtKodeObat.Text;
                obat.exp_date = dpExp.Value;
                obat.jumlah = Convert.ToInt64(txtJumlah.Text);
                obat.harga = Convert.ToInt64(txtHarga.Text);
                int n = obat.addData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal disimpan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil disimpan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    obat.getData(null, dgObat);
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
                if (obat.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan diedit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJumlah.Text) || String.IsNullOrEmpty(txtHarga.Text))
                {
                    MessageBox.Show("Lengkapi semua data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                obat.nama_obat = txtNamaObat.Text;
                obat.kode_obat = txtKodeObat.Text;
                obat.exp_date = dpExp.Value;
                obat.jumlah = Convert.ToInt64(txtJumlah.Text);
                obat.harga = Convert.ToInt64(txtHarga.Text);
                int n = obat.editData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obat.id = 0;
                    clear();
                    obat.getData(null, dgObat);
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
                if (obat.id == 0)
                {
                    MessageBox.Show("Mohon pilih obat yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = obat.deleteData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil dihapus", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obat.id = 0;
                    clear();
                    obat.getData(null, dgObat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validasi_AngkaTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            obat.getData(txtFind.Text, dgObat);
        }

        private void dgObat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                obat.id= Convert.ToInt32(dgObat.Rows[row_index].Cells[0].Value.ToString());
                obat.kode_obat = dgObat.Rows[row_index].Cells[1].Value.ToString();
                obat.nama_obat= dgObat.Rows[row_index].Cells[2].Value.ToString();
                obat.exp_date = Convert.ToDateTime(dgObat.Rows[row_index].Cells[3].Value.ToString());
                obat.jumlah = Convert.ToInt64(dgObat.Rows[row_index].Cells[4].Value.ToString());
                obat.harga = Convert.ToInt64(dgObat.Rows[row_index].Cells[5].Value.ToString());
                txtKodeObat.Text = obat.kode_obat;
                txtNamaObat.Text = obat.nama_obat;
                dpExp.Value = obat.exp_date;
                txtJumlah.Text = obat.jumlah.ToString();
                txtHarga.Text = obat.harga.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
