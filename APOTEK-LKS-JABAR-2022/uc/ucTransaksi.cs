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
    public partial class ucTransaksi : UserControl
    {
        Transaksi transaksi = new Transaksi();
        private bool sudahDiBayar = false;

        public ucTransaksi()
        {
            InitializeComponent();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void autoComplete()
        {
            try
            {
                var dt = Connect.getData("SELECT * FROM tbl_obat ORDER BY nama_obat ASC");
                var collection = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                    collection.Add(dt.Rows[i]["nama_obat"].ToString());
                txtNamaObat.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtNamaObat.AutoCompleteSource = AutoCompleteSource.CustomSource;

                txtNamaObat.AutoCompleteCustomSource = collection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void refreshDg()
        {
            if (transaksi.kernajang.Count > 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = transaksi.kernajang;
                dgKeranjang.DataSource = bs;
                lblTotal.Text =  transaksi.kernajang.Sum(x => x.total_harga).ToString();
            }
            else
            {
                dgKeranjang.DataSource = null;
            }
        }

        private void clear()
        {
            cbxTipeResep.SelectedIndex = -1;
            txtNoResep.Clear();
            dpTglResep.Value = DateTime.Now;
            txtNamaPasien.Clear();
            txtNamaDokter.Clear();
            txtNamaObat.Clear();
            txtQuantity.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxTipeResep.SelectedIndex == -1 || String.IsNullOrEmpty(txtNoResep.Text) || String.IsNullOrEmpty(txtNamaPasien.Text) || String.IsNullOrEmpty(txtNamaDokter.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Lengkapi semua data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                keranjang k = new keranjang();
                k.tipe_resep = cbxTipeResep.SelectedItem.ToString();
                k.no_resep = txtNoResep.Text;
                k.tgl_resep = dpTglResep.Value.ToString("yyyy-MM-dd");
                k.nama_pasien = txtNamaPasien.Text;
                k.nama_dokter = txtNamaDokter.Text;
                k.nama_obat = txtNamaObat.Text;
                k.qty = Convert.ToInt32(txtQuantity.Text);
                bool a = transaksi.addKeranjang(k, transaksi);
                if (!a)
                {
                    MessageBox.Show(transaksi.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                refreshDg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            try
            {
                transaksi.kernajang.Clear();
                dgKeranjang.DataSource = null;
                lblTotal.Text = "";
                lblKembalian.Text = "";
                sudahDiBayar = false;
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (sudahDiBayar == false)
                {
                    MessageBox.Show("Silahkan melakukan pembayaran terlebih dahulu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (transaksi.kernajang.Count < 1)
                {
                    MessageBox.Show("Keranjang kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = transaksi.saveData(transaksi.kernajang);
                if (n == 0)
                {
                    MessageBox.Show("Gagal menyimpan transakasi", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    sudahDiBayar = false;
                    transaksi.kernajang.Clear();
                    refreshDg();
                    clear();
                    lblKembalian.Text = "";
                    lblTotal.Text = "";
                    MessageBox.Show("Transaksi berhasil disimpan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            int total = transaksi.kernajang.Sum(x => x.total_harga);
            if (total > Convert.ToInt32(txtUang.Text))
            {
                MessageBox.Show("Uang anda kurang", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int kembalian = Convert.ToInt32(txtUang.Text) - total;
            lblKembalian.Text = kembalian.ToString();
            sudahDiBayar = true;
        }

        private void ucTransaksi_Load(object sender, EventArgs e)
        {
            autoComplete();
        }

    }
}
