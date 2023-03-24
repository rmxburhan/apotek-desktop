using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022.models
{
    public class Obat
    {
        public int id { get; set; }
        public string kode_obat { get; set; }
        public string nama_obat { get; set; }
        public DateTime exp_date { get; set; }
        public long jumlah { get; set; }    
        public long harga { get; set; }
        public int addData(Obat obat)
        {
            string sql = "INSERT INTO tbl_obat (kode_obat, nama_obat, expired_date, jumlah, harga) values(@kode_obat, @nama_obat, @expired_date, @jumlah, @harga)";
            var args = new Dictionary<string, object>
            {       
                {"@kode_obat",obat.kode_obat },
                {"@nama_obat", obat.nama_obat },
                {"@expired_date", obat.exp_date.ToString("yyyy-MM-dd HH:mm:ss") },
                {"@jumlah", obat.jumlah},
                {"@harga", obat.harga }
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public int editData(Obat obat)
        {
            string sql = "UPDATE tbl_obat SET kode_obat = @kode_obat, nama_obat = @nama_obat, expired_date = @exp_date, jumlah = @jumlah , harga = @harga WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id",obat.id},
                {"@kode_obat",obat.kode_obat},
                {"@nama_obat", obat.nama_obat},
                {"@exp_date", obat.exp_date.ToString("yyyy-MM-dd")},
                {"@harga", obat.harga},
                {"@jumlah", obat.jumlah}
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public int deleteData(Obat obat)
        {
            string sql = "DELETE FROM tbl_obat WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", obat.id }
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public void getData(string search, DataGridView dg)
        {
            string sql = $"SELECT * FROM tbl_obat {(String.IsNullOrEmpty(search) ? "" : $"WHERE nama_obat OR kode_obat LIKE '%{search}%'")} ORDER BY id DESC";
            var data = Connect.getData(sql);
            dg.DataSource = data;
        }
    }
}
