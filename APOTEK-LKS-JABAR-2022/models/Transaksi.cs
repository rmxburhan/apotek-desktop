using APOTEK_LKS_JABAR_2022.uc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace APOTEK_LKS_JABAR_2022.models
{
    public class Transaksi
    {
        public List<keranjang> kernajang = new List<keranjang>();
        public Resep resep = new Resep();
        public string message = "";

        public int saveData(List<keranjang> _list)
        {
            string sql_insert = $"INSERT INTO tbl_transaksi values(@no_transaksi, @tgl_transaksi, @nama_kasir, @total_bayar, @obat_id, @user_id, @resep_id)";
            string sql_transaksi = $"INSERT INTO tbl_transaksi values(@no_transaksi, @tgl_transaksi, @nama_kasir, @total_bayar, @obat_id, @user_id";
            int n = 0;
            string sql2 = "SELECT TOP 1 id FROM tbl_resep ORDER BY id DESC";
            string no_transaksi = "INV" + DateTime.Now.ToString("yyyyMMddHHmmss");
            foreach (var k in _list)    
            {
                if (k.tipe_resep == "DENGAN RESEP")
                {
                    resep.no_resep = k.no_resep;
                    resep.tgl_resep = Convert.ToDateTime(k.tgl_resep);
                    resep.nama_pasien = k.nama_pasien;
                    resep.nama_dokter = k.nama_dokter;
                    resep.obat_resep = k.nama_obat;
                    resep.jumlah_obat = k.qty;
                    resep.addData(resep);

                    var datas = Connect.getData(sql2);
                    if (datas.Rows.Count > 0)
                    {
                        int id = Convert.ToInt32(datas.Rows[0][0].ToString());
                        k.resep_id = id;
                    }
                    var args = new Dictionary<string, object>
                    {
                        {"@no_transaksi",  no_transaksi},
                        {"@tgl_transaksi", DateTime.Now.ToString("yyyy-MM-dd") },
                        {"@nama_kasir", LoginSession.nama },
                        {"@total_bayar", k.total_harga },
                        {"@obat_id", k.obat_id },
                        {"@user_id", k.user_id },
                        {"@resep_id", k.resep_id }
                    };
                    n += Connect.executeWrite(sql_insert, args);
                }
                else
                {
                    var args = new Dictionary<string, object>
                    {
                        {"@no_transaksi",  no_transaksi},
                        {"@tgl_transaksi", DateTime.Now.ToString("yyyy-MM-dd") },
                        {"@nama_kasir", LoginSession.nama },
                        {"@total_bayar", k.total_harga },
                        {"@obat_id", k.obat_id },
                        {"@user_id", k.user_id },
                    };
                    n += Connect.executeWrite(sql_transaksi, args);
                }
            }
            return n;
        }

        public bool addKeranjang(keranjang k, Transaksi t)
        {
            string sql = $"SELECT id, harga FROM tbl_obat WHERE nama_obat = '{k.nama_obat}'";
            var data = Connect.getData(sql);
            if (data.Rows.Count > 0)
            {
                k.obat_id = Convert.ToInt32(data.Rows[0][0].ToString());
                k.harga = Convert.ToInt32(data.Rows[0][1].ToString());
            }

            else
            {
                message = "Obat tidak ditemukan";
                return false;
            }

            if (!(k.tipe_resep == "DENGAN RESEP"))
            {
                k.no_resep = "";
                k.tgl_resep = "";
                k.nama_dokter = "";
                k.nama_pasien = "";
            }
            k.user_id = LoginSession.id;
            t.kernajang.Add(k);
            return true;
        }
    }
}
