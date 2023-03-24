using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting;
using System.Net.Configuration;
using System.Data;
using System.Data.SQLite;

namespace APOTEK_LKS_JABAR_2022
{
    public class Connect
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_apotek;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();

        private static void openCon()
        {
            connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_apotek;Integrated Security=True");
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        private static void closeCon()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static int insertLog(string aktifitas)
        {
            try
            {
                int rows = 0;
                openCon();
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd = new SqlCommand($"INSERT INTO tbl_log values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{aktifitas}', '{LoginSession.id}')", connection);
                rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    Console.WriteLine("Gagal menginsert log");
                else
                    Console.WriteLine("Berhasil menginsert log");

                return rows;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public static int executeWrite(string sql, Dictionary<string, object> args)
        {
            try
            {
                int numberOfRowsAffected;
                openCon();
                //open a new command
                using (cmd = new SqlCommand(sql, connection))
                {
                    //set the arguments given in the query
                    foreach (var pair in args)
                    {
                        cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    //execute the query and get the number of row affected
                    Console.WriteLine(cmd.CommandText);
                    numberOfRowsAffected = cmd.ExecuteNonQuery();
                }
                closeCon();
                return numberOfRowsAffected;
            }
            catch (Exception ex)
            {
                closeCon();
                Console.WriteLine(ex.ToString());
                return 0;
            }
        }

        public static DataTable getData(string sql)
        {
            Console.WriteLine(sql);
            DataTable data = new DataTable();
            openCon();
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.Fill(data);
            closeCon();
            return data;
        }
    }
}
