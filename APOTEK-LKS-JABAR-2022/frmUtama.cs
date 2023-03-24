using APOTEK_LKS_JABAR_2022.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022
{
    public partial class frmUtama : Form
    {
        ucKelolaObat menuObat = new ucKelolaObat();
        ucKelolaResep menuResep = new ucKelolaResep();
        ucKelolaUser menuUser = new ucKelolaUser();
        ucLaporan menuLaporan = new ucLaporan();
        ucLogAktivity menuLog = new ucLogAktivity();
        ucTransaksi menuTransaksi = new ucTransaksi();
        ucPengaturan menuPengaturan = new ucPengaturan();
        public frmUtama(string tipe)
        {
            InitializeComponent();

            menuObat.Dock = DockStyle.Fill;
            menuResep.Dock = DockStyle.Fill;
            menuUser.Dock = DockStyle.Fill;
            menuLaporan.Dock = DockStyle.Fill;
            menuLog.Dock = DockStyle.Fill;
            menuTransaksi.Dock = DockStyle.Fill;

            // set nama welcome
            labelWelcome.Text = "Selamat Datang, " + LoginSession.nama;
            labelNamaAplikasi.Text = Properties.Settings.Default.namaAplikasi;

            multiAuth(tipe);
        }

        private void multiAuth(string tipe)
        {
            if (tipe != "admin")
                flowLayoutPanel1.Visible = false;
            else
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuLog);
            }

            if (tipe == "apoteker")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuResep);
            }
            else if (tipe == "kasir")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuTransaksi);
            }
        }

        private void frmUtama_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuObat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLaporan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLog);
        }
        CultureInfo ci = new CultureInfo("id-ID");
        private void timerDate_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss", ci);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuPengaturan);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuUser);
        }
    }
}
