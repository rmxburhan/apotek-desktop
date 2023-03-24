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
    public partial class ucLogAktivity : UserControl
    {
        public ucLogAktivity()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            string sql = $"SELECT * FROM tbl_log INNER JOIN tbl_user ON tbl_log.user_id = tbl_user.id WHERE waktu between '{dpExp.Value.ToString("yyyy-MM-dd")}' AND '{dpExp.Value.ToString("yyyy-MM-dd")} 23:59:59' ORDER BY tbl_log.id DESC";
            DataTable dt = Connect.getData(sql);
            Console.WriteLine(dt.Rows.Count); 
            dgLog.DataSource = dt;
            dgLog.Columns[0].Visible = false;
        }

        private void ucLogAktivity_Load(object sender, EventArgs e)
        {
            dpExp.Value = DateTime.Now;
            getData();
        }
    }
}
