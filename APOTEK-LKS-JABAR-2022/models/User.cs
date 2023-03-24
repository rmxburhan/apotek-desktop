using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTEK_LKS_JABAR_2022.models
{
    public class User
    {
        public int id { get; set; }
        public string tipe_user { get; set; }
        public string nama { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string telepon { get; set; }
        public string alamat { get; set; }

        public int addData(User user)
        {
            string sql = "INSERT INTO tbl_user values(@tipe_user, @nama, @password, @username, @telepon, @alamat)";
            var args = new Dictionary<string, object>
            {
                {"@tipe_user",user.tipe_user },
                {"@nama", user.nama },
                {"@username", user.username },
                {"@password", user.password },
                {"@telepon", user.telepon},
                {"@alamat", user.alamat}
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public int editData(User user)
        {
            string sql = "UPDATE tbl_user SET tipe_user = @tipe_user, nama = @nama, username = @username, password = @password, telepon = @telepon , alamat = @alamat WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id",user.id},
                {"@tipe_user",user.tipe_user },
                {"@nama", user.nama },
                {"@username", user.username },
                {"@password", user.password },
                {"@telepon", user.telepon},
                {"@alamat", user.alamat}
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

       
        public bool login(User user)
        {
            string sql = $"SELECT * FROM tbl_user WHERE username = '{user.username}' AND password = '{user.password}'";
            var data = Connect.getData(sql);
            if (data.Rows.Count > 0)
            {
                LoginSession.id = Convert.ToInt32(data.Rows[0]["id"].ToString());
                LoginSession.nama = data.Rows[0]["nama"].ToString();
                LoginSession.username = data.Rows[0]["username"].ToString();
                LoginSession.password = data.Rows[0]["password"].ToString();
                LoginSession.tipe = data.Rows[0]["tipe_user"].ToString();
                Connect.insertLog("Login");
                return true;
            }
            else
            {       
                return false;
            }
        }
        public int deleteData(User user)
        {
            string sql = "DELETE FROM tbl_user WHERE id = @id";
            var args = new Dictionary<string, object>
            {
                {"@id", user.id }
            };
            int n = Connect.executeWrite(sql, args);
            return n;
        }

        public void getData(string search, DataGridView dg)
        {
            string sql = $"SELECT * FROM tbl_user {(String.IsNullOrEmpty(search) ? "" : $"WHERE nama LIKE '%{search}%'")}ORDER BY id DESC";
            var data = Connect.getData(sql);
            dg.DataSource = data;
        }

    }
}